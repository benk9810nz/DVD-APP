# C# DVD App

## Introduction

This application is a simple C# program that reads & Writes to an MYSQL Database that contains information about DVDs. I created this application as a Class Exercise and then improved on it by adding an Add/Edit/Remove Option (in class we were only instructed to make it list all the DVDs).

## How to launch this application

Before the Application can be launched an MYSQL Database must be created using the supplied SQLDUMP.sql File. Once this has been created and the SQL Server has been set up and is running, the Application on the first run will ask for the Configuration Details (Server IP Address, Username, Database, Password) if it is unable to connect to an MYSQL Database.
Once the MYSQL Database is set up and running the Application can then be launched by either clicking the run button in Visual Studio or by clicking the DVDAPP.exe Executable in \DVD-APP\DVDApp\bin\Debug Folder.

## Please Note:
When Launching this application there is a slight delay as the Application when it launches tries to establish a connection with the Database. It can sometimes take up to 10 seconds for it to connect to the application. If it can not connect to the Database the Database Configuration window appears.
### This Application only works with MYSQL Databases

@ Ben King 2019
