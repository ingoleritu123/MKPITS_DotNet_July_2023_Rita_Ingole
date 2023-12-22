create table store3(store_id int identity(100,110) primary key,store_name varchar(100),phone_no  varchar(100),email varchar(100),street varchar(100),
city varchar(50),state varchar(50),zipcode varchar(50))


insert into store3 values('antique cloth store','8657976945','rituingole2@gamil.com','nandvan','nagpur','maharastra','441002')
insert into store3 values('prem cloth store','8657780945','prembhar2@gamil.com','sadar','nagpur','maharastra','441002')
insert into store3 values('vyanti undergarments','9022511679','vyant678@gamil.com','darshan colony','nagpur','maharastra','441002')
insert into store3 values('mahavir general nstore','9579286231','mahavir6782@gamil.com','bhandevali','nagpur','maharastra','441002')
insert into store3 values('lakshmi fertilizer store','9373347798','lakshmi2342@gamil.com','pardi','nagpur','maharastra','441002')

select * from store3
 alter table store3
 add constraint unique_email
 unique(email);


 create table staff2(staff_id int identity primary key,first_name varchar(40)not null,last_name varchar (50)not null,email varchar(50),
 phone varchar(12) not null, active_days int ,store_id int,manager_id int
 constraint fk40 foreign key(store_id) references store3(store_id))

 insert into staff2 values('ritu','ingole','rituingole2@gmail.com',   '9579286231',500,100,105)
 insert into staff2 values('riya','gharde','riyagharde2@gmail.com',   '8657976945',400,210,106)
 insert into staff2 values('pihu','gajbhiye','gajbhiyepihu2@gmail.com','9022511679',450,320,107)
 insert into staff2 values('Anu','wankhede','wankhedeanu2@gmail.com',  '9373347798',300,430,106)
 insert into staff2 values('nitya','kale','nitu456@gmail.com',         '8806069843',150,540,100)

 select * from staff2

 drop table staff2


 create table categories3(category_id int identity(2,5)primary key,category_name varchar(500))

 insert into categories3 values('car')
 insert into categories3 values('bike')
 insert into categories3 values('electric mofet')
 insert into categories3 values('mofet')
 insert into categories3 values('jeeb')

 select * from categories3

 drop table categories3


 create table brand(brand_id INT IDENTITY (2, 5) PRIMARY KEY,
	brand_name VARCHAR (255) NOT NULL)

	insert into brand values('marutisuzuki')
	insert into brand values('varna')
	insert into brand values('audi')
	insert into brand values('thar')

create table products4 (product_id int identity (3, 6) primary key,product_name varchar (255) NOT NULL,brand_id int NOT NULL,
category_id int NOT NULL,model_year int NOT NULL,list_price dec (10, 2) NOT NULL,
constraint fk46 foreign key (category_id) references categories3(category_id))

insert into products4 values('car',3456,2,2016,1000000)
insert into products4 values('bike',7866,2,2018,1500000)
insert into products4 values('mofet',9856,2,2019,2000000)
insert into products4 values('bicycle',3876,2,2012,9000000)
insert into products4 values('truck',6745,2,2015,1500000)



select * from products4


create table customers(customer_id int identity primary key,first_name varchar(500),last_name varchar(50),phone_no varchar(12),
email varchar(50),street varchar(50),city varchar(50) not null,state varchar(50), zipcode int not null)

insert into customers values('r



       
