create table product19(prodect_id int identity primary key,product_name varchar(100),model nvarchar(50),price int)

insert into product19 values('car','varna',60000)
insert into product19 values('bus','matoshree',700000)
insert into product19 values('bike','maruti',1.50000)
insert into product19 values('truck','suzuki',2000000)
insert into product19 values('scarpio','thar',560000)
insert into product19 values('car','suzuki',670000)



select * from product19



create procedure p5
as
begin
select product_name ,price
from
product19 
order by price
end

exec p5

exec p5
alter procedure p5
as 
begin
insert into product19 values('car','swift',80000)
end

ALTER PROCEDURE p5
    AS
    BEGIN
        SELECT 
            product_name, 
            price
        FROM 
            product19
        ORDER BY 
            price 
    END;

	exec p5



