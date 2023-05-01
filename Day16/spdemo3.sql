create or alter procedure SP_showdeptname(@id int) as
begin
	select * from Dept where DeptName=@id;

end;




execute SP_showdeptname 12