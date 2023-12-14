CREATE TABLE customer1
(
"customerid" int identity(1,1) primary key,
"Name" varchar(50),
"Age" int NOT NULL,
"city" varchar(50),
"salary" numeric
);


INSERT INTO customer1
(Name,Age,city,salary)
VALUES
('ritu',21,'kamptee',80000),
('jitu',25,'kamptee',90000),
('ritu',27,'nagpur',80000),
('siya',20,'kamptee',85000),
('ram',31,'nashik',50000);

select * from customer1

select * from customer1 where name <> 'ritu'


select distinct 'nagpur' from customer1

drop table customer1
