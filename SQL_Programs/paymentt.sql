create table paymentt(customer_id int identity primary key,amount int,mode varchar(20),payment_date date)

insert into paymentt values(4000,'online','8-10-2001')
insert into paymentt values(7000,'cash','4-10-2001')
insert into paymentt values(98000,'cradit card','6-10-2001')
insert into paymentt values(4000,'debit card','3-10-2001')
insert into paymentt values(4000,'UPI','5-10-2001')
insert into paymentt values(3000,'wallet','9-10-2001')


select * from paymentt

select SUM(amount) As 'Total Sum'
from paymentt

select avg(amount) as 'total avg'
from paymentt



