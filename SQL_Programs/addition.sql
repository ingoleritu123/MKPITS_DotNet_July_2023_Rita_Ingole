create function fn_addition(@num as int)
returns int
as
begin
    return (@num+@num)
end

select dbo.fn_addition(10);



create procedure sp_addition
as
begin
   select dbo.fn_addition(5)
end
execute sp_addition;