# C# DVD App

## Introuduction

This application is a simple C# Program which reads & Writes to a MYSQL Database that contains information about DVDS. I created this application as a Class Exercise,
and then improved on it by by adding an Add/Edit/Remove Option (in class we were only instructed to make it list all the DVD's).

## How to launch this application

Before the Application can be launched an MYSQL Database must be created using the supplied SQLDUMP.sql File. Once this has been created and the SQL Server has been setup and is running, the Applicaiton on first run will ask for the Configuration Details (Server IP Address, Username, Database, Password)
if it is unable to connect to a MYSQL Database.

Once the MYSQL Database is setup and running the Applicaton can then be launched by either clicking the run button in Visual Studio, or by clicking the DVDAPP.exe Executable
in \DVD-APP\DVDApp\bin\Debug Folder.

## Please Note:
When Launching this application there is a slight delay as the Application when it launches tries to establish a connection with the Database. It can sometimes
take up to 10 seconds for it to connect to the application

@Ben King 2019