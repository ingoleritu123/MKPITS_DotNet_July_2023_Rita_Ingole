create table product13(product_id int identity primary key,product_name varchar(50),product_price int)

insert into product13 values ('desktop',5000)
insert into product13 values('maouse',700)
insert into product13 values('keyboed',900)
insert into product13 values('mousepad',400)
insert into product13 values('printer',1000)



select * from product13

update product13 set product_price=10000
where product_name='desktop'

update product13 set product_price=300
where product_name='keyboard' 

delete  from product13 
where product_name='maouse'


select * from product13








exec alldata

create procedure alldata product13 @product_name varchar(50)
as
begin
select *from product13 where product_name=@product_name
end 
go

exec alldata @product_name='desktop'

drop table product13