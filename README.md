# Documentation of ExpenseTracker
This is an expense tracker web application. The goals of the web application are, easily manage your daily expenditures list, find out expenditures in a specific period, maintain expenditures list according to various categories, etc.

## What technologies have been used to create the application?
1. ASP.NET Core MVC.
2. ASP.NET Core Framework 5.
3. Entity Framework Core.
4. MS SQL server.
5. Bootstrap
6. Code-First approach of system development.

## How is the database designed?
<p align="center">
  <img src="Screenshots\0.1_Database_Diagram.png" width="820" height="440"><br/>
  <i>0.1 Database Diagram</i>
</p>

- **Database :** The database was designed by the code first approach. Here we have two tables one is Categories and another one is Expenses. The relation between those tables is One-to-Many. In the Categories table, the primary key is CategoryId on the other hand in the Expenses table primary key is ExpenseId whereas the foreign key is CategoryId. ( *Screenshot 0.1* )

## what are the features of ExpenseTracker web application?
<h2 align="center">Category</h2>

<p align="center">
  <img src="Screenshots\1.1Category_List.png" width="820" height="440"><br/>
  <i>1.1 Cateogry Index</i>
</p>

- **Index :** The category index page, shows the list of all the categories ( *Screenshot 1.1* ).

<p align="center">
  <img src="Screenshots\1.2_Add_Category.png" width="820" height="440"><br/>
  <i>1.2 Create Category</i>
</p>

- **Create :** On the Category Create View, you can create a new expense category at a time ( *Screenshot 1.2* ). A special feature of the Create View is, you can not record a new category that already exists. If your given category name already exists, it will show an error message.

<p align="center">
  <img src="Screenshots\1.3_Update_Cateogry.png" width="820" height="440"><br/>
  <i>1.3 Update Cateogry</i>
</p>

- **Update :** On the Category Update View, you can edit an expense category that is recorded  ( *Screenshot 1.3* ). Here I also provide the facility to prevent users to update as duplicate category.

<p align="center">
  <img src="Screenshots\1.4_Delete_Category.png" width="820" height="440"><br/>
  <i>1.4 Delete Category</i>
</p>

- **Delete :** Selected category can be deleted here ( *Screenshot 1.4* ).

<h2 align="center">Special features of Category section</h2>

<p align="center">
  <img src="Screenshots\1.5_Prevent_Duplicate_Category.png" width="820" height="440"><br/>
  <i>1.5 Prevent Duplicate Category</i>
</p>

- **Prevent Duplicate Expense Category :** To prevent users from creating duplicate Expense Category, Before saving the data that comes from user input. I compare the data with existing expense categories from the database in Category Controller. If the given data won't match with any of the existing records then save it into the database otherwise show an error message ( *Screenshot 1.5* ).


<h2 align="center">Expense</h2>

<p align="center">
  <img src="Screenshots\2.1_Expense_List.png" width="820" height="440"><br/>
  <i>2.1 Expense Index</i>
</p>

- **Index :** The expense index page, shows the list of all the categories ( *Screenshot 2.1* ). There is also a special feature that you can see the expenditure list of a certain time period.

<p align="center">
  <img src="Screenshots\2.2_Add_Expense.png" width="820" height="440"><br/>
  <i>2.2 Create Expense</i>
</p>

- **Create :** On the Expense Create View, you can list an expense under an expense category ( *Screenshot 2.2* ). A special feature of the Create View is, you can not provide a future date as an expense date.

<p align="center">
  <img src="Screenshots\2.3_Update_Expense.png" width="820" height="440"><br/>
  <i>2.3 Update Expense</i>
</p>

- **Update :** On the Expense Update View, you can edit an expense record ( *Screenshot 2.3* ). Here, you also can not update a future date as an expense date.

<p align="center">
  <img src="Screenshots\2.4_Delete_Expense.png" width="820" height="440"><br/>
  <i>2.4 Delete Expense</i>
</p>

- **Delete :** You will be able to delete a selected expense by the Delete View ( *Screenshot 2.4* ).

<h2 align="center">Special features of Expense section</h2>

<p align="center">
  <img src="Screenshots\2.5_Future_Date_Validation.png" width="820" height="440"><br/>
  <i>2.5 Future Date Validation</i>
</p>

- **Future Date Validation :** To prevent users to record any expenditure on a future date, I have created a class in the name of FutureDateValidation which inherited ValidationAttribute class ( *Screenshot 2.5* ). 

<p align="center">
  <img src="Screenshots\2.6_Date_Filter.png" width="820" height="440"><br/>
  <i>2.6 Date Filter</i>
</p>

- **Date Filter :** If you let it empty, all the lists of the expense will be shown on the index view. If you give dates in the field from and to, It will show those lists of the expense that had been recorded in a certain period. I pass two date values into Index Action as optional parameters. If those two parameters have values then compare those values with existing data of the database and return particular data to show on index view ( *Screenshot 2.6* ).

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
