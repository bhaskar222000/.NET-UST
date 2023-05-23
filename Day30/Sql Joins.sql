select Employee.name ,Department.dept_id,Department.salary from
Department join Employee on Department.dept_id=Employee.dept_id order by name;

select Employee.name ,Department.dept_id,Department.salary from
Department left join Employee on Department.dept_id=Employee.dept_id order by name;

select Employee.name ,Department.dept_id,Department.salary from
Department right join Employee on Department.dept_id=Employee.dept_id where salary>45000 order by name;

select Employee.name ,Department.dept_id,Department.salary from
Department cross join Employee 

select *from Department join Employee on Department.dept_id=Employee.dept_id

select * from Department cross join Employee