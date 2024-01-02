create table employee0 (EmpId int primary key, empname varchar(20))

CREATE TABLE EmpLog0 (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)


create trigger emp0
on employee0
for insert
as
insert into
emplog0 (Empid,Operation,UpdatedDate)
select EmpId,'insert',getdate() from
inserted


insert into employee values(12,'amita')
select * from employee
select * from emplog