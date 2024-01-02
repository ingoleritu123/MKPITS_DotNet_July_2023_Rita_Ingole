create function TakeNumber(@num as int)
returns  int
as 
begin
   return (@num*@num)

end

select dbo.TakeNumber(2);



