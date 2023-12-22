create table product5(product_id int identity primary key,product_name varchar(100)not null,prize int not null,quantity int not null)

insert into product5 values('Desktop',50000,1)
insert into product5 values('Keybord',900,2)
insert into product5 values('Mouse',2000,3)
insert into product5 values('Mousepad',5000,4)
insert into product5 values('CPU',70000,1)

select * from product5

update product5 set prize=3000
where product_name='Keybord'


update product5 set prize=500
where product_name='Mousepad'

delete from product5
where product_name='Mousepad'

drop table product5

