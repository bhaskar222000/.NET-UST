create or alter procedure SP_getsalary
@id int,@salary money output
as
begin
select @salary=salary from Emp where Id=@id;
end;


declare @id int;
declare @salary money;
exec SP_getsalary @id=1 , @salary = @salary output;

