 create table jobs(
job_id int primary Key not null,
job_title varchar(20),
min_salary money,
max_salary money
);


create table regions(
region_id int primary key not null,
region_name varchar(20)
);


create table countries(
country_id int primary key not null,
country_name varchar(20),
region_id int ,
foreign key(region_id) references regions(region_id)
);


create table locations
(
location_id int primary key not null,
street_address varchar(20),
postal_code int,
city varchar(20),
state_province varchar(20),
country_id int,
foreign key(country_id) references countries(country_id)
);


create table departments(
department_id int primary key not null,
department_name varchar(20),
manager_id int ,
location_id int,
foreign key(location_id) references locations(location_id),
);


create table Employees(
employee_id int primary key not null,
first_name varchar(20),
last_name varchar(20),
email varchar(20),
phone_number numeric,
hire_date date,
job_id int,
salary money,
commition_pct money,
manager_id int,
department_id int,
foreign key(job_id) references Jobs(job_id),
foreign key(department_id) references departments(department_id),
);


create table job_history(
employee_id int,
start_date date,
end_date date,
job_id int,
department_id int,
foreign key(job_id) references jobs(job_id),
foreign key(employee_id) references employees(employee_id),
foreign key(department_id) references departments(department_id)
);