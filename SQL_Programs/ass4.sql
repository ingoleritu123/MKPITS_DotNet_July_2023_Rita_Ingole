create table getempdetails12(emp_id int,emp_name varchar(50),salary int)

insert into getempdetails12 values(1,'riru',56000)
insert into getempdetails12 values(2,'kiru',76000)
insert into getempdetails12 values(3,'siru',96000)
insert into getempdetails12 values(4,'riru',66000)
insert into getempdetails12 values(2,'miru',86000)

select * from getempdetails12 

create procedure pro12
as
begin
select * from getempdetails12
insert into getempdetails12 values (1,'titu',87000)
end
exec pro12
select * from getempdetails12 



drop table getempdetails12
drop procedure pro12

