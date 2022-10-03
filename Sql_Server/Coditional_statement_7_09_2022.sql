         ----------Database used(Condition_Statement)-----------------
--------------------------------------------------------------------------
                        --student table creation
create table student(roll_no int,f_name varchar(20),l_name varchar(20),city varchar(20))
insert into student values(11,'Gayatri','Sable','Pune')
insert into student values(21,'Achal','Parise','Nagpur')
insert into student values(32,'Priyanka','Upadhyay','Pune')
insert into student values(47,'Shivani','Bhad','Nagpur')
insert into student values(55,'Sakshi','Dod','Thane')
select * from student

----------------------------------------------------------------------
                       -- where clause examples
					   --1)Simple Equallity
select * from student where roll_no=1
select * from student where roll_no>1                         -- using comparative operator
select * from student where f_name='Gayatri'
select * from student where city='Pune'
                           
						   
						   -- 2)Two condition (and operator)
select * from student where f_name='Gayatri' and city='Pune'
select * from student where l_name='Sable' and city='Nagpur'
select * from student where roll_no>1 and city='Nagpur'          -- using comparative operator

----------------------------------------------------------------------------
                          -- 3)Two condition (or operator)
select * from student where roll_no>=31 or city='Pune'            -- using comparative operator
select * from student where l_name='Sable' or city='Pune'

----------------------------------------------------------------------------
                           -- 4)Two condition (between operator)range----
select * from student where roll_no between 1 and 30	 
	
----------------------------------------------------------------------------
                           -- 5) condition where (or operator) used
select * from student where roll_no in(11,47,55)	
----------------------------------------------------------------------------
                           -- 5) condition where (LIKE operator) used
select * from student where f_name like '%ya%'
select * from student where f_name like 'k%'
select * from student where f_name like '%i'
select * from student where f_name like '%al'
---------------------------------------------------------------------------------------
                    --one more example with between operator
create table order1(order_id int,product_name varchar(20),cust_name varchar(20),quantity int ,order_date date)
insert into order1 values(1,'mouse','Gayatri',5,'2022-9-7')
--select * from order1
insert into order1 values(3,'Monitor','Priyanka',3,'2022-2-7')
insert into order1 values(2,'keyboard','Neha',2,'2022-3-7')
insert into order1 values(5,'keyboard','Sonali',3,'2022-5-1')
select * from order1
select * from order1 where order_date between'2022-5-1' and '2022-9-7'
