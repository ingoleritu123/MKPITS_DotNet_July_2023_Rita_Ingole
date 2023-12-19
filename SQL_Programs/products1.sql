create table products1(product_id int identity(2,4) primary key,productname varchar(200),
    unit_price dec(10,2) check(unit_price > 0))

insert into products1 values('sofa',50000)
insert into products1 values('bed',25000)
insert into products1 values('dinning',5000)
insert into products1 values('refrigerator',60000)

select * from products1

drop table products1