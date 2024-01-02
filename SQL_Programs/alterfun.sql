create function division(@num as int)
returns int
as 
begin
    return (@num/@num)
end

select dbo.division(2)


alter function division(@num as int)
returns int
as
begin
   return (@num*@num*@num)
end

select dbo.division(2)