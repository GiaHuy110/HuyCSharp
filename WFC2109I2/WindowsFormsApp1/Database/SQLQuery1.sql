use master 
go

drop database if exists WFC2109I2
create database WFC2109I2
go

use WFC2109I2
go

create table Student
(
	Id int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender bit,
	Dob date,
)
go

insert into Student(FirstName, LastName, Gender, Dob)
values
(N'Trần', N'Gia Huy', 'true', '2022-05-21')
go 10