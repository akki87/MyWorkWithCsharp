CREATE TYPE EmployeeType AS TABLE
(
	Id int,
    FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Dob date ,
    Email VARCHAR(50))

create proc InsertEmployees (@Employee as EmployeeType ReadOnly) 
as 
Begin
	insert into Employee
	select * from @Employee;
End
select * from Employee



