create table getemployeedatabydepartment(name varchar(50),department_id int,department_name varchar(40))


insert into getemployeedatabydepartment values('ritu',123,'CSE')
insert into getemployeedatabydepartment values('ritu',123,'civil')
insert into getemployeedatabydepartment values('ritu',123,'mechanical')
insert into getemployeedatabydepartment values('ritu',123,'ETC')
insert into getemployeedatabydepartment values('ritu',123,'civil')

select * from getemployeedatabydepartment


create procedure getemp
(@depa_id as int)
as
begin
select * from getemployeedatabydepartment
where department_id=@depa_id
end


exec getemp 123
drop procedure getemp