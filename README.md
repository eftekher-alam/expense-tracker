# Documentation of ExpenseTracker
This is an expense tracker web application. The goals of the web application are, easily manage of your daily expenditures list, find out expenditure in a specific time period etc.

## What are the requirements to run the web application?
Make sure that mentioned below components are installed on your computer.
1. .NET 5.0 [Download Link](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
2. SQL Server 2019 [Download Link](https://www.microsoft.com/en-sg/sql-server/sql-server-downloads)
3. Visual Studio 2019 [Download Link](https://visualstudio.microsoft.com/)

## How to run the web application?
1. Open **ExpenseTracker.sln** file with Visual Studio
2. Go to **Build -> Build Solution (Ctrl+Shift+B)**
3. Go to **View -> Other Windows -> Package Manager Console**
4. In the Package Manager Console run the following command 
    ```update-database```
    It will create a new database in the name "eftekhar" in your database if doesn't exist previously.
5. Go to **Solution Explorer -> Views (Expand the folder) -> -> Home (Expand the folder) -> Index   (Right click) -> View in browser**

