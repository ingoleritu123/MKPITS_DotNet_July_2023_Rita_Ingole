create table products(product_id int identity(2,4) primary key,productname varchar(200),unit_price dec check (unit_price>0))

insert into products values('sofa',50000)
insert into products values('bed',25000)
insert into products values('dinning',5000)
insert into products values('refrigerator',60000)

select * from products

drop table products