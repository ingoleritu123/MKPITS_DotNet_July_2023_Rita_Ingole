create table tnation(nation_id int primary key,nation_name varchar(100))

insert into tnation values(12,'India')
insert into tnation values(13,'USA')

select * from tnation


-------------------------------

create table tstate(state_id int primary key,nation_id int,nation_name varchar(100)
constraint fk90 foreign key(nation_id) references tnation(nation_id))

insert into tstate values(11,12,'punjab')
insert into tstate values(22,12,'delhi')
insert into tstate values(33,13,'california')
insert into tstate values(44,13,'san doe')

select * from tstate

-----------------------------------------------

create table tcity (city_id int identity primary key,state_id int,city_name varchar(100)
constraint fk100 foreign key(state_id) references tstate(state_id))

insert into tcity values(11,'jalandar')
insert into tcity values(11,'jamnagar')
insert into tcity values(22,'noyeda')
insert into tcity values(22,'chandigarh')
insert into tcity values(11,'AAAA')
insert into tcity values(11,'BBBBB')
insert into tcity values(11,'CCCCC')
insert into tcity values(11,'DDDDD')

select * from tcity