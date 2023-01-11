# RSDO (Razvoj Slovenščine v Digitalnem Okolju) - Concordancer
This repository contains the source code of the concordancer which is a part of the [Terminology Portal](https://github.com/clarinsi/rsdo_term_portal).

There are two main parts:
- Web application with backend (API interface) written in ASP.NET Core 6 and frontend written in React
- System Manager which is written in .NET 6 and is used to initially set up the system

## Prerequisites
Web application requires following external dependencies
- OpenSearch v2.3.0 (use docker image: `opensearchproject/opensearch:2.3.0`)
- PostgreSQL (use docker image: `postgres`)

## Building source code
### Frontend (React application)
To build a frontend application successfully, first, [Node.js](https://nodejs.org/en/) must be installed (at least version 16).
Use `npm install` to install all required dependencies, and `npm run build` to build the application.
For more info see the [Readme](src/apps/Rsdo.Concordancer.Api/WebApp/README.md) inside the frontend [root](src/apps/Rsdo.Concordancer.Api/WebApp) folder.

### Backend (ASP.NET Core 6) and System Manager (.NET 6)
Open [Rsdo.Concordancer.sln](src/Rsdo.Concordancer.sln) inside of your IDE and build the solution, or use `dotnet build` command to build the solution. All required dependencies will be installed via NuGet packages.

## Creating docker images
There are two Dockerfile's in the source repository for each part. Both images should be compiled within the context of the project root folder.

### Web application
[Dockerfile](src/apps/Rsdo.Concordancer.Api/Dockerfile) for Web Application accepts additional optional argument (WEBAPP_PUBLIC_URL) which is mapped to React [PUBLIC_URL](https://create-react-app.dev/docs/using-the-public-folder/) variable. If the variable is omited, then application should be deployed on a domain root.

`docker build -t rsdo-concordancer-api -f src/apps/Rsdo.Concordancer.Api/Dockerfile .`

`docker build --build-arg WEBAPP_PUBLIC_URL=/corpus -t rsdo-concordancer-api -f src/apps/Rsdo.Concordancer.Api/Dockerfile .`

### System Manager
Use following [Dockerfile](src/apps/Rsdo.Concordancer.SystemManager/Dockerfile) to build System Manager.

`docker build -t rsdo-concordancer-systemmanager -f src/apps/Rsdo.Concordancer.SystemManager/Dockerfile .`

## Environment variables

### Web application
Web application must be configured with the following Environment variables and values:
- `RSDO:Database:MasterConnectionString` holds connection string to the main database; e.g.: `rsdo_db;Username=rsdo;Password=strongpassword;Database=Concordancer`
- `RSDO:Elastic:ConnectionString` holds connection string to OpenSearch server; e.g.: `http://rsdo_opensearch:9200`
- `RSDO:Tokenizer:ClasslaUrl` holds and url to external service which is used for tokenizing search strings; e.g.: `https://orodja.cjvt.si/oznacevalnik/ajax_api/v1/slv/process`

### System Manager
System manager must be configured with the following Environment variables and values:
- `RSDO:Database:MasterConnectionString` holds connection string to the main database; e.g.: `rsdo_db;Username=rsdo;Password=strongpassword;Database=Concordancer`
- `RSDO:Elastic:ConnectionString` holds connection string to OpenSearch server; e.g.: `http://rsdo_opensearch:9200`

## Using System Manager
To initialy setup the system, you have to use System Manager and run following commands:
1. `dotnet Rsdo.Concordancer.SystemManager.dll createMasterDb --connectionString="Host=rsdo_db;Username=rsdo;Password=strongpassword;Database=postgres"` which will create master database with the name Concordancer. You can select different name with the `--name` option
2. `dotnet Rsdo.Concordancer.SystemManager.dll importSloleks --sourceFile=/data/Sloleks2.0.LMF/sloleks_clarin_2.0.xml` which will import Sloleks (which is used for better searching). XML file is not part of this repository, but it can be downloaded from the following [URL](https://www.clarin.si/repository/xmlui/bitstream/handle/11356/1230/Sloleks2.0.LMF.zip?sequence=3&isAllowed=y)
