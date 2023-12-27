create table product18(prodect_id int identity primary key,product_name varchar(100),model nvarchar(50),price int)

insert into product18 values('car','varna',60000)
insert into product18 values('bus','matoshree',700000)
insert into product18 values('bike','maruti',1.50000)
insert into product18 values('truck','suzuki',2000000)
insert into product18 values('scarpio','thar',560000)
insert into product18 values('car','suzuki',670000)



select * from product18

create procedure proc2
as
begin
select product_name,price
from 
product18
order by price
end;

exec proc2