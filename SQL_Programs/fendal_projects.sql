create table nation(Nation_id int primary key,Nation_name varchar(500))

insert into nation values(1,'India')
insert into nation values(2,'United_Nation')
insert into nation values(3,'Napal')
insert into nation values(4,'ShreeLanka')

select * from nation

-------------------------------------------------------------------------------------
create table State(state_Id int primary key,state_name varchar(500),Nation_id int,
constraint fk60 foreign key(Nation_id) references nation(Nation_id))

insert into State values(123,'AndhraPradesh',1)
insert into State values(456,'Punjab',1)
insert into State values(789,'Calfornia',2)
insert into State values(098,'Florida',2)
insert into State values(765,'Koshi',3)
insert into State values(432,'Bagmati',3)
insert into State values(849,'Colombo',2)
insert into State values(396,'Ratnapura',2)

select * from State

-----------------------------------------------------------------------------------------
create table City(city_Id int primary key,city_name varchar(100),state_Id int,
constraint fk73 foreign key(state_Id) references State(state_Id))


insert into City values(101,'VishakhaPatnam',123)
insert into City values(102,'vijayvada',123)
insert into City values(103,'Guntur',123)
insert into City values(104,'Amritsar',456)
insert into City values(105,'Jalindar',456)
insert into City values(106,'Chandigarh',456)
insert into City values(107,'LosAngeles',789)
insert into City values(108,'San jose',789)
insert into City values(109,'San Diego',789)
insert into City values(110,'Jacksonville',098)
insert into City values(111,'Miami',098)
insert into City values(112,'Tampa',098)
insert into City values(101,'Damak',765)
insert into City values(101,'Daran',765)
insert into City values(101,'BiratNagar',765)
insert into City values(101,'Banepa',432)
insert into City values(101,'BharatPur',432)
insert into City values(101,'Hetauda',432)
insert into City values(101,'GrandPass',849)
insert into City values(101,'Borella',849)
insert into City values(101,'Pettah',849)
insert into City values(101,'Balangoda',396)
insert into City values(101,'Kolonna',396)
insert into City values(101,'Panamure',396)

Select * from City

