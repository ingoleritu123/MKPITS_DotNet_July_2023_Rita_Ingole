create function checkvoterage(@age as int)
returns varchar(100)
as
begin
      declare @str varchar(100)
	  if(@age>=18)
	  begin
	      set @str='Eligible For Vote'
	  end
	  else
	  begin
	     set @str='not eligible for vote'
	  end
	  return @str
end

select dbo.checkvoterage(20);