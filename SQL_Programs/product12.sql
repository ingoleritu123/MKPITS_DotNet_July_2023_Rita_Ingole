create table product12(product_id int identity primary key,product_name varchar(50),product_price int)

insert into product12 values ('desktop',5000)
insert into product12 values('maouse',700)
insert into product12 values('keyboed',900)
insert into product12 values('mousepad',400)
insert into product12 values('printer',1000)



select * from product12

update product12 set product_price=10000
where product_name='desktop'

update product12 set product_price=300
where product_name='keyboard' 

delete  from product12 
where product_name='maouse'


select * from product12


