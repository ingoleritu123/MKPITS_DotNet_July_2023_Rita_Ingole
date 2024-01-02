create table product(product_id int identity primary key,product_name varchar(500),brand_id int unique,model_year int,list_price int not null)

insert into product values('CD100',123,2004,60000)
insert into product values('splender',673,2006,70000)
insert into product values('activa',678,2007,69000)
insert into product values('chetak',876,2009,90000)
insert into product values('herohonda',345,2014,160000)

select * from product


