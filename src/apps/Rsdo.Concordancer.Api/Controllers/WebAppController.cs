using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Rsdo.Concordancer.Core.Constants;

namespace Rsdo.Concordancer.Api.Controllers
{
    public class WebAppController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment webHostEnvironment;

        public WebAppController(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            this.configuration = configuration;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var indexFilePath = webHostEnvironment.WebRootFileProvider.GetFileInfo("index.html").PhysicalPath;
            var html = new HtmlDocument();
            html.Load(indexFilePath);

            var baseAppPath = configuration[ConfigurationKey.Web.BaseAppPath] ?? string.Empty;
            var scriptNode = HtmlNode.CreateNode($"<script>window.baseAppPath = '{baseAppPath}';</script>");
            var headNode = html.DocumentNode.SelectSingleNode("//head");
            headNode.ChildNodes.Add(scriptNode);

            var indexStream = new MemoryStream();
            html.Save(indexStream);
            indexStream.Position = 0;

            return File(indexStream, MediaTypeNames.Text.Html);
        }
    }
}