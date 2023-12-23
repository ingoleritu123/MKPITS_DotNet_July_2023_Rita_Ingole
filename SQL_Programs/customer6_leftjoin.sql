create table customer6(customer_id int identity primary key,customer_name varchar(100),product varchar(50),city varchar (100))


create table payment2(customer_id int identity primary key,amount int not null,mode varchar(50),pament_date date)



insert into customer6 values('ritu','sofa','nagpur')
insert into customer6 values('Anu','bed','nagpur')
insert into customer6 values('riya','table','nagpur')
insert into customer6 values('urvashi','chair','nagpur')
insert into customer6 values('nitu','press','nagpur')


insert into payment2 values(10000,'online','4-10-2001')
insert into payment2 values(15000,'cash','4-10-2001')
insert into payment2 values(5000,'upi','4-10-2001')
insert into payment2 values(2000,'craditcard','4-10-2001')
insert into payment2 values(6000,'debitcard','4-10-2001')



select * from customer6
select * from payment2


select * from customer6 as c
inner join payment2 as p
on c.customer_id=p.customer_id

select customer_name,amount,pament_date,mode
from customer6 as c
inner join payment2 as p
on c.customer_id=p.customer_id

select * from customer6 as c
left join payment2 as p
on c.customer_id=p.customer_id

select customer_name,amount,pament_date,mode
from customer6 as c
left join payment2 as p
on c.customer_id=p.customer_id

