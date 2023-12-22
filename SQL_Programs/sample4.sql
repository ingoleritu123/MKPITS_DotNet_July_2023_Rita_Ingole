create table sample4(sample_id int identity primary key,sample_name varchar(100)not null)

insert into sample4 values('mouse')
insert into sample4 values('keybord')
insert into sample4 values('cpu')
insert into sample4 values('desktop')

select * from sample4

update sample4 set sample_name='mousepad'
where sample_id=1

delete from sample4
where sample_id=1

truncate table sample4

insert into sample4 values('mouse')
insert into sample4 values('keybord')
insert into sample4 values('cpu')
insert into sample4 values('desktop')

select * from sample4

alter table sample4
add price int not null

update sample4 set price=500
where sample_id=1

update sample4 set price=900
where sample_id=2

update sample4 set price=50000
where sample_id=3

update sample4 set price=7000
where sample_id=4

select * from sample4
