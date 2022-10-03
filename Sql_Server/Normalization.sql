-------------------------database use(Normalization)-------------------
---------- 1 st example of composite key--------------
CREATE TABLE student(rollNumber INT, 
                  name1 VARCHAR(30), 
                  course VARCHAR(30), 
                  section VARCHAR(3), 
                  mobile bigint,
                  PRIMARY KEY (rollNumber, mobile)); -----------------composite key

insert into student values(1,'amit','dotnet','i','1234567890')
insert into student values(1,'amit','dotnet','i','1234567891')
insert into student values(2,'Neha','java','ii','1234567845')
insert into student values(3,'Radha','Php','iii','1234567459')
insert into student values(3,'Radha','Php','iii','1234567359')
select *from student

---------------------------------------------------------------------------------------------------------------------
--------------------------1Nf---------1st normalization form-------------------
-----------------------example 1 Nf----------------------------------------------------------------
------------------      EMPLOYEE table:
------------------          EMP_ID 	    EMP_NAME        EMP_PHONE 			          EMP_STATE
------------------            14 		John 		7272826385, 9064738238 	           UP
------------------           20 	    Harry           8574783832 			           Bihar
---------------             12           Sam 		     390372389, 8589830302               Punjab
------------------------------------------------------------------------------------------------------
create table employee(emp_id int,
                       emp_name varchar(10),
					   emp_phone bigint,
					   emp_state varchar(10),
					   primary key(emp_id,emp_phone)) ---------------------------composite key
insert into employee values(14,'John',7272826385,'Up')
insert into employee values(14,'John',9064738238,'Up')
insert into employee values(20,'Harry',8574783832,'Bihar') 	
insert into employee values(12,'Sam',390372389,'Punjab')
insert into employee values(12,'Sam',8589830302,'Punjab')
select * from employee
--------------------------------------------------------------------------------------------------------------------------------
----------------------------------2Nf-----------------------------------------------------------------
------TEACHER table                                           
------TEACHER_ID  	SUBJECT 	TEACHER_AGE          TEACHER_ID 	TEACHER_AGE
------25 		    Chemistry 	 30                     25 	    	30
------25 		     Biolog 	 30                     47          35
------47 		      English 		35                   83         38
------83 		         Math 		38
------83 		       Computer 	38
---------------------------------------------------------------------------------------------
create table teacher_detail(teacher_id int primary key,teacher_age int)
insert into teacher_detail values(25,30)
insert into teacher_detail values(47,35)
insert into teacher_detail values(83,38)
select *from teacher_detail

create table teacher_subject(teacher_id int,subject varchar(20),
constraint t1 foreign key(teacher_id) references teacher_detail(teacher_id))

insert into teacher_subject values(25,'chemistry')
insert into teacher_subject values(25,'Biology')
insert into teacher_subject values(47,'English')
insert into teacher_subject values(83,'Math')
insert into teacher_subject values(83,'Computer')
select *from teacher_subject
select*from teacher_detail

--==========================================================================================================
--EMPLOYEE_DETAIL table:
--    EMP_ID  EMP_NAME 	   EMP_ZIP 	 EMP_STATE 	 EMP_CITY
--    222 		Harry 		201010 		UP 		  Noida
--    333 		Stephan 	201010		UP		  Noida
--    444 		Lan 		60007 		US 		  Chicago
--    555 		Katharine 	06389 		UK 		  Norwich
--    666 		John 		462007 		MP 		  Bhopal
--    777 		Harry	    9999		MP		  Bhopal

--========================================== 3NF ==========================================================

create table employee_table (emp_id int ,
							 emp_name varchar(20),
							 emp_zip int,
							 primary key(emp_id,emp_zip));
							

insert into employee_table values(222,'Harry',201010)
insert into employee_table values(333,'Stephan',201010)
insert into employee_table values(444,'Lan',60007)
insert into employee_table values(555,'Katharine',06389)
insert into employee_table values(666,'John',462007)
insert into employee_table values(777,'Harry',9999)

select * from employee_table

create table employee_zip(emp_zip int primary key, 
						  emp_state varchar(20),
						  emp_city varchar(20),
						  constraint e1 foreign key (emp_zip) references employee_zip(emp_zip));

insert into employee_zip values(201010,'UP','Noida')
insert into employee_zip values(02228,'US','Boston')
insert into employee_zip values(60007,'US','Chicago')
insert into employee_zip values(06389,'UK','Norwich')
insert into employee_zip values(462007,'MP','Bhopal')

select * from employee_zip 
select * from employee_table


--======================================================================================================
