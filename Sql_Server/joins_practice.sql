                                  -- database used(join)pratice
--========================================= Joins =================================================
                                     -- 1)Inner Join --
create table student(id int primary key,
					 admission_no int,
					 f_name varchar(20),
					 l_name varchar(20),
					 age int,
					 city varchar(20))
insert into student values(21,212121,'Gayatri','Sable',22,'Pune')
insert into student values(22,222222,'Priyanka','Upadhyay',22,'Mumbai')
insert into student values(23,232323,'Radha','Kakde',21,'Thane')
insert into student values(24,242424,'Neha','Dod',22,'Nagpur')
insert into student values(25,252525,'Nikita','Parate',22,'Nagpur')
insert into student values(26,262626,'Mona','Bhad',22,'Wardha')
insert into student values(27,272727,'Sakshi','Dod',21,'Nagpur')
select * from student

create table fee(admission_no int,
				 course varchar(20), 
				 amount_paid int)

insert into fee values(212121,'Java',10000)
insert into fee values(222222,'Python',9000)
insert into fee values(232323,'c++',7000)
insert into fee values(242424,'c#',8000)

select * from fee

select student.admission_no,student.f_name,student.l_name,fee.course,fee.amount_paid from student
inner join fee
on student.admission_no=fee.admission_no;    -- showing common things
--=================================================================================================
                                 --2)Cross Join--
-->1
select student.admission_no,student.f_name,student.l_name,fee.course,fee.amount_paid from student
cross join fee
-->2
select student.admission_no,student.f_name,student.l_name,fee.course,fee.amount_paid from student
cross join fee
where student.admission_no=fee.admission_no;
------------------------------------------------------------------------------------------------------
                -- another example of cross join --
select * from customer cross join orders                           -- reference from join_assignment

--================================================================================================
							 -- 3.1)Left Outer Join --

create table student_19(id int primary key,
					 admission_no int,
					 f_name varchar(20),
					 l_name varchar(20),
					 age int,
					 city varchar(20))
insert into student_19 values(21,212121,'Gayatri','Sable',22,'Pune')
insert into student_19 values(22,222222,'Priyanka','Upadhyay',22,'Mumbai')
insert into student_19 values(23,232323,'Radha','Kakde',21,'Thane')
insert into student_19 values(24,242424,'Neha','Dod',22,'Nagpur')
insert into student_19 values(25,252525,'Nikita','Parate',22,'Nagpur')
insert into student_19 values(26,262626,'Mona','Bhad',22,'Wardha')
insert into student_19 values(27,272727,'Sakshi','Dod',21,'Nagpur')
select * from student_19

create table fees(admission_no int,
				 course varchar(20), 
				 amount_paid int)

insert into fees values(212121,'Java',10000)
insert into fees values(222222,'Python',9000)
insert into fees values(232323,'c++',7000)
insert into fees values(242424,'c#',8000)
insert into fees values(266666,'c',7000)

select * from fees

select student_19.admission_no,student_19.f_name,student_19.l_name,fees.course,fees.amount_paid from student_19
left outer join fees
on student_19.admission_no=fees.admission_no;

--================================================================================================
							 -- 3.2)Right Outer Join --

select student_19.admission_no,student_19.f_name,student_19.l_name,fees.course,fees.amount_paid from student_19
right outer join fees
on student_19.admission_no=fees.admission_no;

--================================================================================================
							 -- 3.3)Full Outer Join --

select student_19.admission_no,student_19.f_name,student_19.l_name,fees.course,fees.amount_paid from student_19
full outer join fees
on student_19.admission_no=fees.admission_no;


--=================================================================================================

create table customer_19 (cust_id int,cust_name varchar(20),state varchar(20),city varchar(20))

insert into customer_19 values(1,'Gayatri','MP','Pune')
insert into customer_19 values(2,'Gayatri','MP','Pune')
insert into customer_19 values(3,'Gayatri','MP','Pune')
insert into customer_19 values(4,'Gayatri','MP','Pune')
insert into customer_19 values(5,'Gayatri','MP','Pune')

select c1.cust_name,c2.state,c2.city
from customer_19 c1,customer_19 c2
WHERE c1.cust_id <> c2.cust_iD and c1.city = c2.city
ORDER BY c2.city

--============================================================================================

