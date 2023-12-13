create table student2(studentid int identity(1,1) primary key,studentname varchar(30),address varchar(30))

select * from student2


insert into student2(studentname,address) values ('pari','khaparkheda')
insert into student2(studentname,address) values ('saki','chankapur')
insert into student2(studentname,address) values ('sarthvi','kanhan')
insert into student2(studentname,address) values ('narikshit','khaparkheda')
insert into student2(studentname,address) values ('karinita','wadi')
insert into student2(studentname,address) values ('rariniti','indors')
insert into student2(studentname,address) values ('dranita','narkheda')

select * from student2 order by  studentname 


select * from student2 where studentname='pari'
drop table student2

