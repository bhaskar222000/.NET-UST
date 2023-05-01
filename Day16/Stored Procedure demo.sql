create or alter procedure sp_printdate as
begin
select getdate();
end;

exec sp_printdate /*executing)*/