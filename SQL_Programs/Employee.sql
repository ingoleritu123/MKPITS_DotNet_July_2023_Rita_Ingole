create table employee(empid int primary key identity (1,1),emp_name varchar(20),designation varchar(30))

select * from employee

insert into employee(emp_name,designation) values ('ravi','peun')
insert into employee(emp_name,designation) values ('savi','manager')
insert into employee(emp_name,designation) values ('mavi','clerk')
insert into employee(emp_name,designation) values ('kavi','asistant')

select * from employee
drop table employee




