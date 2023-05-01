create trigger emp_trigger on Emp
after insert 
as
select 'Row created';


insert into Emp values(3,'Ro',45000);

select * from Emp;