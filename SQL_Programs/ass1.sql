create table getempcounto(emp_id int,emp_name varchar(50),emp_no int)

insert into getempcounto values(1,'riru',56)
insert into getempcounto values(2,'kiru',76)
insert into getempcounto values(3,'siru',96)
insert into getempcounto values(4,'riru',66)
insert into getempcounto values(5,'miru',86)

select * from getempcounto


create procedure p5
as
begin
select * from getempcounto
end

exec p5

select count(emp_id) as 'total employee' from getempcounto

drop table getempcounto
drop procedure p5