DROP TABLE dbo.Employees;

CREATE TABLE dbo.Employees
(
Gender varchar(max),
Title varchar(max),
GivenName varchar(max),
MiddleInitial varchar(max),
Surname varchar(max),
City varchar(max),
"State" varchar(max),
ZipCode varchar(max),
Birthday DateTime,
);

-- truncate the table first
TRUNCATE TABLE dbo.Employees;
GO
 
-- import the file
BULK INSERT dbo.Employees
FROM 'C:\Users\robin\source\repos\CannAmm - Assignment\EmployeeDirectory\EmployeeDirectoryApp\Resources\employee-list.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=2
)
GO

Alter Table dbo.Employees
Add Id int identity(1,1);
Select * From dbo.Employees;
