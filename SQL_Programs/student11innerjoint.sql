create table student11(admission_no int identity primary key ,student_id int ,first_name varchar(100),last_name varchar(100),
age int not null,city varchar(100))


create table fee(admission_no int not null,course varchar(100),amount_paid int not null)



insert into student11 values(123,'ritu','ingole',22,'nagpur')
insert into student11 values(673,'anu','wankhede',20,'nagpur')
insert into student11 values(193,'riya','kakde',21,'nagpur')
insert into student11 values(894,'ritika','ingle',22,'nagpur')

insert into fee values(1,'Dotnet',75000)
insert into fee  values(2,'java',70000)
insert into fee  values(3,'python',63000)
insert into fee  values(4,'machinelearning',15000)



    SELECT student11.admission_no, student11.first_name, student11.last_name,student11.age,student11.city, Fee.course, Fee.amount_paid  
    FROM student11  
    INNER JOIN Fee  
    ON student11.admission_no = Fee.admission_no;  


select * from student11
select * from fee


drop table student
drop table fee
