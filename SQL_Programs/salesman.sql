create table salesman(salesmanid int ,name varchar(100),city varchar(60),commission numeric)

insert into salesman values (123,'parikshit','nagpur',500)
insert into salesman values (183,'shital','nagpur',1000)
insert into salesman values (823,'pari','vardha',700)
insert into salesman values (103,'parinita','bhandara',900)
insert into salesman values (423,'parimit','gondia',500)
insert into salesman values (129,'parthav','naagpur',450)

select * from salesman

select top 2 salesmanid,name from salesman  order by name desc

select top 6 salesmanid,name from salesman  order by name desc

select top 2 salesmanid,name from salesman  order by salesmanid 



select top 2 salesmanid,name from salesman  order by salesmanid asc

