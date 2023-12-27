create table emp12(emp_id int,emp_name varchar(50),emp_no int, salary int)

insert into emp12 values(1,'ritu',123,65000)
insert into emp12 values(2,'gitu',123,67000)
insert into emp12 values(3,'bitu',567,56000)
insert into emp12 values(4,'uitu',124,45000)
insert into emp12 values(5,'iitu',129,59000)

select * from emp12

create proc pre1
(@sal as int)
as
begin
select salary
from
emp12
where salary>@sal
end

exec pre1 45000

