create table kemployee(emp_id int identity primary key,emp_name varchar(50))

create table kemplog(emplog_id int identity primary key,emp_id int,operation varchar(50),upadattedDate Datetime not null)

CREATE TRIGGER memp
on kemployee
for insert 
as
insert into 
kemplog(emp_id,operation,upadatteddate)
select emp_id,'insert',GETDATE() from
inserted;


insert into kemployee values('amit')
select * from kemployee
select * from kemplog

insert into kemployee values('amita')
select * from kemployee
select * from kemplog

