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
insert into Student(FirstName, LastName, Gender, Dob)
values
(N'Lê', N'Công Vinh', 'true', '2022-05-21')
insert into Student(FirstName, LastName, Gender, Dob)
values
(N'Trần', N'Hoàng Nam', 'true', '2022-05-21')
insert into Student(FirstName, LastName, Gender, Dob)
values
(N'Nguyễn', N'Ngọc Thùy Trang', 'true', '2022-05-21')
insert into Student(FirstName, LastName, Gender, Dob)
values
(N'Lê', N'Thị Thu Huyền', 'true', '2022-05-21')
go

create proc UpdateStudent
@Id int, @FirstName nvarchar(50), @LastName nvarchar(50), @Gender bit, @Dob date
as 
begin
	Update Student
	set FirstName=@FirstName, LastName=@LastName, Gender=@Gender, Dob=@Dob
	where Id=@Id
end
go