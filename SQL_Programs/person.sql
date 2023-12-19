create table person(person_id int identity(10,100) primary key,first_name varchar(200) not null,last_name varchar(50)not null,
email_id varchar(100)unique)

insert into person values('rita','ingole','rituingole2@gmail.com')
insert into person values('mrunali','kakde','mrukakde@gmail.com')
insert into person values('mmanu','ingale','inglemanu@gmail.com')
insert into person values('sayali','dhudas','sayudhudas@gmail.com')
insert into person values('chetna','warade','cheti1234@gmail.com')
insert into person values('pranita','kale','pranukalee23@gmail.com')

select * from person


drop table person