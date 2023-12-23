create table customer5(customer_id int identity primary key,customer_name varchar(100),product varchar(50),city varchar (100))


create table payment(customer_id int identity primary key,amount int not null,mode varchar(50),pament_date date)



insert into customer5 values('ritu','sofa','nagpur')
insert into customer5 values('Anu','bed','nagpur')
insert into customer5 values('riya','table','nagpur')
insert into customer5 values('urvashi','chair','nagpur')
insert into customer5 values('nitu','press','nagpur')


insert into payment values(10000,'online','4-10-2001')
insert into payment values(15000,'cash','4-10-2001')
insert into payment values(5000,'upi','4-10-2001')
insert into payment values(2000,'craditcard','4-10-2001')
insert into payment values(6000,'debitcard','4-10-2001')



select * from customer5
select * from payment


select * from customer as c
inner join payment as p
on c.customer_id=p.customer_id

select customer_name,amount,pament_date,mode
from customer5 as c
inner join payment as p
on c.customer_id=p.customer_id


