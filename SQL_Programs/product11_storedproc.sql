create table product11(prodect_id int identity primary key,product_name varchar(100),model nvarchar(50))

insert into product11 values('car','varna')
insert into product11 values('bus','matoshree')
insert into product11 values('bike','maruti')
insert into product11 values('truck','suzuki')
insert into product11 values('scarpio','thar')
insert into product11 values('car','suzuki')



select * from product11

create procedure p2
as
begin
select * from product11  where model='suzuki'
end

exec p2

