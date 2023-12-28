create function ShowMessage()
returns varchar(500)
as
begin
      return'welcome to mkpit'
end

select 'dbo.ShowMassage()';