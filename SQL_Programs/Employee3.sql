create table Employee3(first_name varchar(50),last_name varchar(50),email nvarchar(50),phone varchar(12),hiredate date,manager_id int,
salary int,department_id int)

create table employeelog(manager_id int,operation varchar(50),updateteddate datetime)

create trigger t1
on Employee3
for insert
as
insert into
employeelog(manager_id,operation,updateteddate)
select manager_id,'insert',GETDATE() from
inserted

insert into Employee3(first_name,last_name,email,phone,hiredate,manager_id,salary,department_id) values('rita','ingole','rituingole2@gmail.com','9579286231','4-10-2001',1234,50000,456)
select * from Employee3
select * from employeelog




