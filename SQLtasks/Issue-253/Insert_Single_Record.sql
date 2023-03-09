Create table Employee(
	Id int Identity(1,1),
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	DOB Date not null,
	Email varchar(50),
	primary key (Id))

create proc InsertEmployee
@FirstName varchar(50),@LastName varchar(50),@Dob Date,@Email varchar(50) as
Begin 
	insert into Employee values(@FirstName,@LastName,@Dob,@Email)
End

select * From Employee


