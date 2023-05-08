declare @salary money;
declare salary_cursor cursor
for
select salary from Emp order by salary;
open salary_cursor;
fetch next from salary_cursor into @salary;
while @@FETCH_STATUS=0
begin
fetch next from salary_cursor into @salary;
end
close salary_cursor
deallocate salary_cursor;


