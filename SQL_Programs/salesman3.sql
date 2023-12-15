create table salesman3(salesmanid int,name varchar(100),city varchar(50),commission float)

insert into salesman3 values(123,'James Hoog','New York' ,0.15)
insert into salesman3 values(124,'Nail Knite',' Paris' ,0.13)
insert into salesman3 values(125,' Pit Alex','London' ,0.11)
insert into salesman3 values(126,'Mc Lyon','Paris' ,0.14)
insert into salesman3 values(127,'Paul Adam','Rome' ,0.13)
insert into salesman3 values(128,'Lauson Hen','San Jose ' ,0.12)

select * from salesman3

select * from salesman3 where city = ' Paris';

select name ,city from salesman3  order by name desc


drop table salesman3