create table getempcount(emp_id int,emp_name varchar(50),emp_no int)

insert into getempcount values(1,'riru',56)
insert into getempcount values(2,'kiru',76)
insert into getempcount values(3,'siru',96)
insert into getempcount values(4,'riru',66)
insert into getempcount values(5,'miru',86)

select * from getempcount

create procedure coup1
as 
begin
select * from getempcount
end

exec coup1

select COUNT (emp_id) as 'Total employee'from getempcount