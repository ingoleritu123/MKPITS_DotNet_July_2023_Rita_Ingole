create table orders3(orderno int primary key,purchaseamt numeric(18,0),orderdate date,customerid varchar(50) NOT NULL)

insert into orders3 values(123,106.5,'2023-12-14','cust@1923')
insert into orders3 values(193,78.6,'2023-12-11','cust@1893')
insert into orders3 values(150,150.5,'2023-12-12','cust@1623')
insert into orders3 values(133,60.80,'2023-12-10','cust@1503')
insert into orders3 values(192,120.8,'2023-12-09','cust@1323')

select * from orders3

select distinct orderno,purchaseamt,orderdate,customerid from orders3 order by  orderno,purchaseamt,orderdate,customerid

drop table orders3