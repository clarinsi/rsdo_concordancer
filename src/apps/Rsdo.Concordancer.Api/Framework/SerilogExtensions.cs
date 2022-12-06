using System;
using System.Net;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;
using Serilog.Sinks.Email;

namespace Rsdo.Concordancer.Api.Framework;

public static class SerilogExtensions
{
    public static LoggerConfiguration RsdoEmail(
        this LoggerSinkConfiguration sinkConfiguration,
        string fromEmail,
        string toEmail,
        string mailServer,
        int port,
        bool enableSsl,
        string userName,
        string password,
        string outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}",
        LogEventLevel restrictedToMinimumLevel = LogEventLevel.Warning,
        int batchPostingLimit = 100,
        string mailSubject = "Log Email")
    {
        var connectionInfo = new EmailConnectionInfo()
        {
            FromEmail = fromEmail,
            ToEmail = toEmail,
            EmailSubject = mailSubject,
            MailServer = mailServer,
            Port = port,
            EnableSsl = enableSsl,
        };

        if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
        {
            connectionInfo.NetworkCredentials = new NetworkCredential()
            {
                UserName = userName,
                Password = password,
            };
        }

        return sinkConfiguration.Email(connectionInfo: connectionInfo, restrictedToMinimumLevel: restrictedToMinimumLevel);
    }
}