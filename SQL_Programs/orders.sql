CREATE TABLE orders
(
"ordersid" int identity(1,1) primary key,
"name" varchar(100),
"rate" numeric,
"quantity" int);

INSERT INTO orders
(name,rate,quantity)
VALUES
('tables1',500,1),
('chair',1000,4),
('bed',5000,1),
('sofa',20000,1),
('refrigerator',60000,1);

select * from orders

select name, rate from orders order by name desc



drop table orders