
# ![dataminers_logo](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/dataminers_logo.jpg) CanEastVending

release 1.0

![caneastvending_logo](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/caneastvending_logo.jpg)

Designed and developed for ENGR 3700U '12.
Technologies used: SOAP, mssql, ASP, XPath, ADO.NET, C#, VS2012

The project is structured like:
```
Projects
│   ├── CanEastVending (desktop application program)
│   │   ├── CanEastVending
│   │   │   ├── App.config
│   │   │   ├── bin
│   │   │   │   ├── Debug
│   │   │   │   │   └── Database.mdf
│   │   │   │   └── Release
│   │   │   ├── CanEastVending.csproj
│   │   │   ├── DatabaseDataSet.cs
│   │   │   ├── DatabaseDataSet.xsc
           ...
│   │   │   ├── frmWebServices.cs
│   │   │   ├── frmWebServices.resx
│   │   │   ├── Global.cs
│   │   │   ├── obj
│   │   │   │   └── Debug
│   │   │   ├── Program.cs
│   │   │   ├── Properties
│   │   │   ├── Resources
│   │   │   │   ├── iVend 2.0.jpg
│   │   │   │   ├── iVend.jpg
│   │   │   │   └── ProVendor.jpg
│   │   │   └── VistaApi.cs
│   │   ├── CanEastVending.sln
│   │   └── CanEastVending.v11.suo
│   └── CanEastVending (web interface)
│       ├── CanEastVending (2).sln
│       └── CanEastVending (2).v11.suo
└── WebSites
    └── CanEastVending
        ├── AboutUs.aspx
        ├── AboutUs.aspx.vb
        ├── App_Code
        │   └── WebService.vb
        ├── App_WebReferences
        │   └── CanEastVendingWebServiceReference
        │       ├── Reference.svcmap
        │       ├── WebService.disco
        │       └── WebService.wsdl
        ├── CanEastVendingView.aspx
        ├── CanEastVendingView.aspx.vb
        ├── CanEastVendingViews.aspx
        ├── CanEastVendingViews.aspx.vb
        ├── Database_log.ldf
        ├── Database.mdf
        ├── Home.html
        ├── images
        │   ├── about_icon.png
        │   ├── BackColor2.gif
        │   ├── BackColorFlipped2.gif
       ...
        │   ├── VendMaster 3000.jpg
        │   ├── VendMaster 4000.jpg
        │   └── vmachine.jpg
        ├── MachinesInOperation.xml
        ├── MachinesInOperation.xsd
        ├── MachinesInOperation.xslt
       ...
        ├── WebService.aspx
        ├── XMLDocumentSearch.aspx
        └── XMLDocumentSearch.aspx.vb
```
Fig 1. Project structure

All of the VS 2012 project solution files for the ASP.NET interface and the C# application are included. The project files were restructured from a 'Visual Studio 2012' directory which contains the 'Projects' and 'WebSites' subdirectories (see Fig 1.)

## Schema

# ![er_schema](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/er_schema.jpg)

# ![relational_schema](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/relational_schema.jpg)

## Build instructions

1. SQL Server must be running prior to running project from source
2. Open Visual Studio 2012, Open Project:

    (ASP.NET) web client: My Documents-> Visual Studio 2012 -> Projects -> CanEastVending (web interface) folder -> CanEastVending (2) MS Visual Studio Solution

    IIS Express is the default server for web application projects in VS2012/2013. Other web server options include Local IIS and custom host; read https://msdn.microsoft.com/en-us/library/58wxa9w5(v=vs.120).aspx

    desktop application: My Documents-> Visual Studio 2012 -> Projects -> CanEastVending (desktop application program) folder -> CanEastVending MS Visual Studio Solution

    To build a binary executable of the `can-east-vending` client, read
    https://msdn.microsoft.com/en-us/library/5tdasz7h(v=vs.110).aspx

    To run client in debug mode, read https://msdn.microsoft.com/en-us/library/dd492157(v=vs.120).aspx


## Screenshots

# Web
![joined_web](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/joined_web.jpg)

# Desktop
