create table persons(personid int identity(1,1) primary key,personname varchar(30),personaddress varchar(30),city varchar(20))

select * from persons


insert into persons(personname,personaddress,city) values('ritu','kamptee','nagpur')
insert into persons(personname,personaddress,city) values('nitu','kasaki','pune')
insert into persons(personname,personaddress,city) values('vitu','panvi','mumbai')
insert into persons(personname,personaddress,city) values('situ','mausi','nagpur')
insert into persons(personname,personaddress,city) values('titu','nanij','kolhapur')
insert into persons(personname,personaddress,city) values('iitu','ramtek','nagpur')
insert into persons(personname,personaddress,city) values('uitu','vishakapatnam','haidrabad')

select * from persons

select * from persons where personname='ritu'

select personname,COUNT(*) from persons where city = 'nagpur' group by personname
drop table persons
