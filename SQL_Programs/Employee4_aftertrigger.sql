create table Employee4(first_name varchar(50),last_name varchar(50),email nvarchar(50),phone varchar(12),hiredate date,emp_id int,
salary int,department_id int)

create table employee_log2(emp_id int,operation varchar(50),updateddate datetime)


create  trigger t4
on Employee4
after update
as
insert into
employee_log2(emp_id,operation,updateddate)
select emp_id,'update',GETDATE() from
deleted; 

select * from Employee4
select * from employee_log2

insert into Employee4(first_name,last_name,email,phone,hiredate,emp_id,salary,department_id) values('rita','ingole','rituingole2@gmail.com','9579286231','4-10-2001',1234,50000,456)
select * from Employee4
select * from employee_log2




