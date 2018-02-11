
# ![caneastvending_logo](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/caneastvending_logo.jpg) CanEastVending

[![GitHub version](https://badge.fury.io/gh/boennemann%2Fbadges.svg)](http://badge.fury.io/gh/boennemann%2Fbadges)

Table of Contents
=================

  * [Abstract](#abstract)
  * [Schema](#schema)
    * [Views](#views)
  * [Build instructions](#build-instructions)
  * [Features](#features)
    * [Web](#web)
    * [Desktop](#desktop)
  * [License](#license)

Abstract
============

`caneast-vending-service` is a vending machine inventory tracking system. Client and server interfaces to be used by all corporate and retail personnel at Can-East Vending Inc.

Designed and developed for ENGR 3700U '12.  
Technologies used: SOAP, mssql, ASP, XPath, ADO.NET, ActiveDirectory, C#, LDAP, VS2012

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
**Fig. 1** *project structure*

All of the VS 2012 project solution files for the ASP.NET interface and the C# application are included. The project files were restructured from a 'Visual Studio 2012' directory which contains the 'Projects' and 'WebSites' subdirectories (see Fig 1.)

Schema
============

# ![er_schema](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/er_schema.jpg)
**Fig. 2** *database ER*

# ![relational_schema](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/relational_schema.jpg)
**Fig. 3** *relational schema*

Relations | Views
--- | ---
Customer | ActiveMachinesInOperation 
Employee | CustRentals 
Location | EmployeesDeliveredPepsi 
Machine | EmployeesWhoHaveDeliveredInOshawa 
MachineInventory | HighCapacityMachinesInStorage 
Orders | LessThanAverageDrinkPrice 
Products | LowInventoryMachines
Rentals | RemainingProductQuantity 
| RentedMachineLocations 
| TorontoOttawaRentedMachines
**Fig. 4** *list of SQL tables and views*

Views
------------
Information about virtual tables used by the vending service to track orders and inventory. Full SQL DDL script found in `Visual Studio 2012\Projects\CanEastVending\bin\Debug\Database.mdf`

View | Description
--- | ---
Active Machines in Operation | This view allows for the managers of Can‐East Vending to get a complete overview of all the machines that they own.  The data from this view can be used to see which geographical locations are serviced by Can‐East vending machines.
Customer Rentals | Can‐East's financing department will need to know which machines are currently being rented and who is renting them. This view also provides an excellent overview of the customer base and can be used to facilitate communications with all of Can‐East's vending partners.
Employees Who Delivered Pepsi | If there's reports from customers that there is a problem with Pepsi products that have been delivered to their location, we will be able to quickly identify which employees have delivered Pepsi products and see if there are any correlations between employees and the customer reports.
Employees Who Delivered in Oshawa | This view provides a similar benefit to the one directly above. If customers in Oshawa are reporting problems with their deliveries, we can quickly and efficiently interview the employees who may be involved in these problems and resolve them as quickly as possible.
High Capacity Machines in Storage | Knows which machines Can‐East has in storage in case of customer demand.  If a customer comes in requesting machines with a large capacity, we need to be able to provide them with the information about which machines we have available as fast as possible in order to increase the chances of closing the deal.
Less Than Average Drink Prices | In order to maximize the sales and revenue from our machines, we need to provide a set of products that covers a range of prices.  This view allows for the customers and Can‐East employees to view the lower cost drinks so that they can decide which drinks they want to optimize the contents of a vending machine.
Low Inventory Machines | Machines that are running low on inventory (less than 50% of their capacity) need to be refilled as soon as possible to ensure that there always will be a product available to the customer. By identifying low inventory machines, our employees will be able to go to the machines and refill them exactly when it is needed.
Remaining Product Quantity | The data generated from this view can be used to determine which products are selling the best when analyzed over a period of time. By providing the customers with the most popular products we will be able to maximize revenue for our machines.
Rented Machine Locations | Geographic data is one of the most important aspects in the successful operation of Can‐East Vending.  This data can be used for a wide variety of reasons from directing marketing to high density areas to providing location maps for technicians and maintenance employees.
Toronto and Ottawa Rented Machines | Since Toronto and Ottawa are the two largest cities in Ontario, it is expected that many of our machines will be concentrated within these cities.  By providing data about only these two cities, Can‐East will be able to better optimize the products and machine placement within the high machine density cities.  
**Fig. 5** *SQL views*

Build instructions
============

1. SQL Server must be running prior to running project from source
2. Open Visual Studio 2012, Open Project:

    (ASP.NET) web client: My Documents-> Visual Studio 2012 -> Projects -> CanEastVending (web interface) folder -> CanEastVending (2) MS Visual Studio Solution

    IIS Express is the default server for web application projects in VS2012/2013. Other web server options include Local IIS and custom host; read https://msdn.microsoft.com/en-us/library/58wxa9w5(v=vs.120).aspx

    desktop application: My Documents-> Visual Studio 2012 -> Projects -> CanEastVending (desktop application program) folder -> CanEastVending MS Visual Studio Solution

    To build a binary executable of the `can-east-vending` client, read
    https://msdn.microsoft.com/en-us/library/5tdasz7h(v=vs.110).aspx

    To run client in debug mode, read https://msdn.microsoft.com/en-us/library/dd492157(v=vs.120).aspx

Features
============

## Web
![joined_web](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/joined_web.jpg)
**Fig. 6** *clockwise from top-left: MachinesInOperation View, XPath Search engine, CanEastvending admin console, FindTimeSpan and ViewCurrentInventory service, Database View homepage, Rented Machine Area View, Low Inventory Machines View, CanEastvending homepage*

## Desktop
![caneastvending_app](https://github.com/ridhwaans/caneast-vending-service/raw/master/screenshots/caneastvending_app.jpg)
**Fig. 7** *app for Desktop homescreen; CanEastVending guest account*

Desktop application leverages ActiveDirectory to allow guests or company users to manage CanEastVending assets. The client interacts with the CanEastVending IIS server and the database (specified by connection string)  

#### ADMIN Features
- View and manage Customers (create/remove cohorts, update profile records)
- View and manage Employees (company directory)
- View and manage Vending Machines in operation (change dates, deploy/recall units, filter by region)
- View and manage Orders (edit machine restock orders, invoices)
- Browse inventory (view brand partners and vending machine products)

License
============

The content of this project itself is licensed under the [Creative Commons Attribution 3.0 license](http://creativecommons.org/licenses/by/3.0/us/deed.en_US), and the underlying source code used to format and display that content is licensed under the [MIT license](http://opensource.org/licenses/mit-license.php).