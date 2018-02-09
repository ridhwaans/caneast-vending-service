
# CanEastVending

ENGR 3700U

Designed and developed for ENGR 3700U '12.
Technologies used: SOAP, mssql, ASP, ADO.NET, C#, VS2012

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

How to build from source (dev build):

0. SQL Server service must be running prior for VS2012 to perform DDL migration
1. Open Visual Studio 2012, Open Project:

a) for the (ASP.NET) website path:
My Documents-> Visual Studio 2012 -> Projects -> CanEastVending (web interface) folder -> CanEastVending (2) MS Visual Studio Solution

b) for the desktop application path:
My Documents-> Visual Studio 2012 -> Projects -> CanEastVending (desktop application program) folder -> CanEastVending MS Visual Studio Solution