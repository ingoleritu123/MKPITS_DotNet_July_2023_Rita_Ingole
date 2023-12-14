CREATE TABLE product2
(
"productname" varchar(100),
"productid" int,
"productprice" numeric,
"quantity" int);

INSERT INTO product2
(productname,productid,productprice,quantity)
VALUES
('microwave',123,500,1),
('gas',567,7000,1),
('washingmachine',789,4000,1),
('AC',678,45000,1),
('TV',567,49000,1);

select * from product2

select top 2 productname,productprice from product2 order by productid desc

SELECT TOP 50 PERCENT
productname,productprice
FROM
product2
ORDER BY
productprice DESC;

select * from product2 where productid<>123
select * from product2 where productname like 'a%'

select * from product2 where productname like '%wave%'


