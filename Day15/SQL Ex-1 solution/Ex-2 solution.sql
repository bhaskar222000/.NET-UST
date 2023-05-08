insert into regions values (3001,'Asia');

insert into countries values(2001,'india',3001);

insert into locations values(1001,'Aluva',684567,'Ernakulam','kerala','2001');

insert into jobs values(4001,'trainee',23000,28000);

insert into Employees values(4001,'John ','Smith','abc@gmail.com',98543322,'2023-02-02',23456,23000,5000,456,201);

insert into job_history values(4001,'2023-02-02','2034-02-02',23456,201);

--4
select first_name,salary,12*(salary+100) from Employees;

--5
update Employees set phone_number='2'+REPLICATE('0',7-len('2'+phone_number))+phone_number
where len(phone_number)=5;

--6
delete from Employees where department_id=90;

--7
select distinct(department_id) from Employees where last_name='Smith';

--8
-- SELECT empname,hire_date HIREDATE, salary FROM EMP ORDER BY hire_date;
select first_name,last_name,hire_date,salary from Employees order by hire_date asc;

 --9
 select student_id,semester_end,gpa from student_grades order by semester_end,gpa desc;

 --10
 select first_name from Employees where department_id not in(select department_id from departments);

 --11
 select concat('Dear Customer',customer_name,' .') from customers;

 --12
 insert into Emp(id,name,sal,comm_pct,pf)
values (1,'John Doe',50000,0.05,5000),
		(2,'Jane Smith',60000,0.1,6000),
		(3,'Bob',75000,0.15,7500);
update Emp set
hra=0.12*sal,
tearn=sal+hra,
tded=0.04*sal,
net=tearn-tded;

