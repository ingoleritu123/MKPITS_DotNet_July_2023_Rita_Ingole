create table order1(order_id int primary key identity,order_name varchar(100),orderdate date,product_rate int,quantity int)


create table order2(order_id int,order_name varchar(100),orderdate date,product_rate int,quantity int
constraint fk foreign key (order_id) references order1(order_id))

insert into order1 values('sofa','04-10-2001',40000,1)
insert into order1 values('chair','07-11-2001',4000,1)
insert into order1 values('bed','05-10-2001',60000,1)
insert into order1 values('tv','09-12-2001',80000,1)

select * from order1

insert into order2 values(1,'table','04-10-2002',4000,1)
insert into order2 values(2,'dinning','07-11-2002',40000,1)
insert into order2 values(3,'mixer','05-10-2002',5000,1)
insert into order2 values(4,'gas','09-12-2002',10000,1)



