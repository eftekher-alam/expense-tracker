# Documentation of ExpenseTracker
This is an expense tracker web application. The goals of the web application are, easily manage your daily expenditures list, find out expenditures in a specific period, maintain expenditures list according to various categories, etc.

## What technologies have been used to create the application?
1. ASP.NET Core MVC.
2. ASP.NET Core Framework 5.
3. Entity Framework Core.
4. MS SQL server.
5. Bootstrap
6. Code-First approach of system development.

## What are the requirements to run the web application?
Make sure that mentioned below components are installed on your computer.
1. .NET 5.0 [Download Link](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
2. SQL Server 2019 [Download Link](https://www.microsoft.com/en-sg/sql-server/sql-server-downloads)
3. Visual Studio 2019 [Download Link](https://visualstudio.microsoft.com/)

## How to run the web application?
1. Open **ExpenseTracker.sln** file with Visual Studio
2. Go to **Build -> Build Solution**
3. Go to **View -> Other Windows -> Package Manager Console**
4. In the **Package Manager** Console run the following command ```update-database``` It will create a new database in the name **eftekher** in your database, if doesn't exist previously.
5. Go to **Solution Explorer -> Views (Expand the folder) -> Home (Expand the folder) -> Index   (Right click) -> View in browser**

## what are the features of ExpenseTracker web application?
### Category
- **Index :** The category index page, shows the list of all the categories
- **Create :** On the Category Create View, you can create a new expense category at a time. A special feature of the Create View is, you can not record a new category that already exists. If your given category name already exists, it will show an error message.
- **Update :** On the Category Update View, you can edit an expense category that is recorded. Here I also provide the facility to prevent users to update as duplicate category.
- **Delete :** Selected category can be deleted here.

### Expense
- **Index :** The expense index page, shows the list of all the categories. There is also a special feature that you can see the expenditure list of a certain time period.
- **Create :** On the Expense Create View, you can list an expense under an expense category. A special feature of the Create View is, you can not provide a future date as an expense date.
- **Update :** On the Expense Update View, you can edit an expense record. Here, you also can not update a future date as an expense date.
- **Delete :** You will be able to delete a selected expense by the Delete View.

## Note
- To prevent users from creating duplicate Expense Category, Before saving the data that comes from user input. I compare the data with existing expense categories from the database in Category Controller. If the given data won't match with any of the existing records then save it into the database otherwise show an error message.
- To prevent users to record any expenditure on a future date, I have created a class in the name of FutureDateValidation which inherited ValidationAttribute class. 
