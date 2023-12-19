create table product4(product_id int identity(5,10) primary key, product_name varchar(200)not null,unit_price dec (10,2),
discounted_price dec(10,2),check(unit_price>0),check(discounted_price>0))

insert into product4 values ('tv',60000,55000);
insert into product4 values ('watch',6000,5500);
insert into product4 values ('washing machine',40000,35000);
insert into product4 values ('aatamaker',3000,2500);
insert into product4 values ('dishwasher',70000,65000);

select * from product4
drop table product4 