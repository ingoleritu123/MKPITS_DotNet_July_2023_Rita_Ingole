create table getempdetails1(emp_id int,emp_name varchar(50),salary int)

insert into getempdetails1 values(1,'riru',56000)
insert into getempdetails1 values(2,'kiru',76000)
insert into getempdetails1 values(3,'siru',96000)
insert into getempdetails1 values(4,'riru',66000)
insert into getempdetails1 values(2,'miru',86000)

select * from getempdetails1 


create procedure p11
as
begin
select * from getempdetails1
where salary>=70000
end

exec p11