                 
				 --------------Database used(clause)------------


-- 1)DISTINCT example  // distinct used to remove duplicate of entered column field
create table customer(cust_id int,cust_name varchar(15),cust_city varchar(15))
insert into customer values (18,'Gayatri','Pune')
insert into customer values (12,'Priyanka','Thane')
insert into customer values (15,'Sonu','Nagpur')
insert into customer values (19,'Aachal','Nagpur')

select distinct cust_city from customer  


----------------------------------------------------------------------------
-- 2)order by example  //  used to sort the column's data as per our need
create table student_data(first_name varchar(15),last_name varchar(15), course varchar(15), city varchar(15),state varchar(15))
insert into student_data values('Gayatri','Sable','Dotnet','Pune','Maharastra')
insert into student_data values('Priyanka','Bhad','Dotnet','Mumbai','Maharastra')
insert into student_data values('Aachal','Sharma','Java','Nagpur','Maharastra')
insert into student_data values('Shivani','Verma','Php','Buldhana','Maharastra')
insert into student_data values('Pardip','Dugane','Java','Nagpur','Maharastra')

 select first_name,last_name,city from student_data order by first_name    --here order of column arranged by first_name   (order of one column)
 ------------------------------------------------------------------------------------------------------------------------------------------------------

 select cust_name,cust_city from customer order by cust_name   --here order of column arranged by cust_name in bydefault ascending order  (order of one column)

 ----------------------------------------------------------------------------------------------------------------------------------------------------------
 select cust_name,cust_city from customer order by cust_name desc; --here order of column arranged by cust_name in descending order  (order of one column)

 ----------------------------------------------------------------------------------------------------------------------------------------------------------------
 select course,city from student_data order by city desc,course asc; --(order of two column)
 select course,city,state from student_data order by state desc,city asc;
 select first_name,last_name,city from student_data order by len(first_name)desc;

 -----------------------------------------------------------------------------------------------------
 -- 3)select TOP clause  
 create table product(pro_id int,pro_name varchar(20),pro_price int,pro_quantity int)
 insert into product values (1,'mouse',120,7)
 insert into product values (5,'keyboard',2000,5)
 insert into product values (3,'monitor',12000,5)
 insert into product values (7,'cpu',20000,5)

 select top 2 pro_name,pro_price from product order by pro_price desc;  -- it shows top 2 expensive 
 select top 70 percent pro_name,pro_price from product order by pro_price asc;    -- it shows top 75% cheap
 ---------------------------------------------------------------------------------------------

 -- 4) Select statement

 select first_name,last_name,course from student_data   --it represents only f_name,l_name and course column
 select * from student_data   -- it represents all column

 -----------------------------------------------------------------------------------
 -- 5) where clause   // used to filter by applying condition
 select * from customer where cust_id=12
 select * from customer where cust_id>12
 select * from customer where cust_id>=19

 select * from student_data where city='Nagpur'
 -----------------------------------------------------------------------------------------
 -- 6)group by clause
 select cust_name,count(*) from customer where cust_city='Nagpur' group by cust_name  -- it counts name available in nagpur city

---------------------------------------------------------------------------------------------
-- 7)having clause

 select city,COUNT(*) from student_data where state = 'Maharastra' group by city having count(*)>1