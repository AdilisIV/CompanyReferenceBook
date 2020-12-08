create database registration
use registration

create table Employee
(
Employee_Id int primary key identity(1,1),
Employee_Name varchar(50),
Employee_FName varchar(50),
Employee_Desgination varchar(50),
Employee_Email varchar(50),
Emp_ID varchar(50),
Gender varchar(50),
Addrss varchar(50)
)

select * from Employee
truncate table employee
insert into Employee values('Asif','Kareem Bux','Programmer','Admin@onlineittuts.com','102757','Male','Pakistan')

create table LoginUsers
(
U_ID int primary key identity(1,1),
U_Name varchar(50),
U_Pass varchar(50),
)

select * from LoginUsers
insert into LoginUsers values ('admin','admin')

