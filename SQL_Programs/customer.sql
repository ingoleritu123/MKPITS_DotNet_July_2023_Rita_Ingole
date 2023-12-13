CREATE TABLE customer
(
"id" int primary key,
"Name" varchar(50) NOT NULL,
"Age" int NOT NULL,
"city" char(50),
"salary" numeric
);

select * from customer

insert into customer(id,Name,Age,city,salary) values(123,'ritu',19,'nagpur',50000)
insert into customer(id,Name,Age,city,salary) values(456,'nitu',19,'nagpur',70000)
insert into customer(id,Name,Age,city,salary) values(789,'ritu',19,'ramtek',60000)
insert into customer(id,Name,Age,city,salary) values(987,'situ',19,'vardha',30000)
insert into customer(id,Name,Age,city,salary) values(765,'ritu',19,'nagpur',20000)

select * from customer