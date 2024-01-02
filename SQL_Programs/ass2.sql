create table getempdetails(emp_id int,emp_name varchar(50),emp_no int)

insert into getempdetails values(1,'riru',56)
insert into getempdetails values(2,'kiru',76)
insert into getempdetails values(3,'siru',96)
insert into getempdetails values(4,'riru',66)
insert into getempdetails values(2,'miru',86)

select * from getempdetails 


create procedure p10
(@empid as int)
as
begin
select * from getempdetails
where emp_id=@empid
end

exec p10   2