use Practice;

Create Table Employee(
ID int Primary Key identity,
Name Varchar(50) Not Null,
[Address] varchar(50) Not Null,
City varchar(30) Not Null,
Contact varchar(11) Not Null
)

Select * from Employee;

Create Procedure AddnewEmployeeDetails(@Name varchar(50),@Address varchar(50),@City varchar(30),@Contact varchar(11))
as
begin
	insert into Employee(Name,Address,City,Contact)Values(@Name,@Address,@City,@Contact);
end;


Create Procedure UpdateEmployeeDetails(@Empid int,@Name varchar(50),@Address varchar(50),@City varchar(30),@Contact varchar(11))
as
begin
	update Employee set Name=@Name,[Address]=@Address,City=@City,Contact=@Contact where ID=@Empid;
end;

Create Procedure DeleteEmployeeDetails(@Empid int)
as
begin
	Delete From Employee where ID=@Empid;
end;

Create Procedure ShowEmployeeDetails
as 
begin
	Select * From Employee;
end;
