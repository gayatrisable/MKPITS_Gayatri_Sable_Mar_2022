---------------------------------------------------databased used all practice question----------------

-------1-1 -Write a SQL statement to display all the information of all salesmen.
------------Sample table: salesman
----------------salesman_id | name | city | commission

-------------------------------->databased used(all practice que)
create table salesman(salesman_id int,salesman_name varchar(20),city varchar(10),commission dec(10,2))
insert into salesman values(5001 , 'James Hoog' ,'New York',0.15)
insert into salesman values(5002,'Nail Knite', 'Paris',0.13)
insert into salesman values(5006,'Mc Lyon', 'Paris', 0.14)
insert into salesman values(5007,'Paul Adam', 'Rome', 0.13)
insert into salesman values(5003,'Lauson Hen','San Jose', 0.12)
--2 Write a SQL statement to display specific columns like name and commission for all the salesmen.
--Sample table: salesman
select*from salesman

------------------------------------------------------------------------------------------------------------------------------------
--3- Write a query to display the columns in a specific order like order date, salesman id, order number and
--purchase amount from for all the orders.
--ord_no purch_amt ord_date customer_id salesman_id
create table saleman_1(order_no int,purchasing_amt dec(10,2),orde_date date,customer_id int,salesman_id int)
insert into saleman_1 values(70001 ,150.5 ,'2012-10-05', 3005 ,5002)
insert into saleman_1 values(70009, 270.65, '2012-09-10', 3001, 5005)
insert into saleman_1 values(70002, 65.26, '2012-10-05', 3002, 5001)
insert into saleman_1 values(70004 ,110.5, '2012-08-17', 3009 ,5003)
insert into saleman_1 values(70005, 2400.6 ,'2012-07-27', 3007, 5001)
insert into saleman_1 values(70008, 5760 ,'2012-09-10', 3002, 5001)

--4- From the following table, write a SQL query to find the unique salespeople ID. Return salesman_id.
--ord_no purch_amt ord_date customer_id salesman_id

select *from saleman_1

select distinct salesman_id from saleman_1

---------------------------------------------------------------------------------------
--5-From the following table, write a SQL query to find the salespeople who lives in the City of 'Paris'.
--Return salesperson's name, city.
--salesman_id | name | city | commission
create table salesman19(salesman_id int,salesman_name varchar(20),city varchar(10),commission dec(10,2))
insert into salesman19 values(5001 , 'James Hoog' ,'New York',0.15)
insert into salesman19 values(5002,'Nail Knite', 'Paris',0.13)
insert into salesman19 values(5006,'Mc Lyon', 'Paris', 0.14)
insert into salesman19 values(5007,'Paul Adam', 'Rome', 0.13)
insert into salesman19 values(5003,'Lauson Hen','San Jose', 0.12)
select * from salesman19 where city='Paris'

--------------------------------------------------------------------------------------------------------------------------------
--6 . From the following table, write a SQL query to find those customers whose grade is 200. Return
--customer_id, cust_name, city, grade, salesman_id.
--customer_id | cust_name | city | grade | salesman_id
create table sales(customer_id int,cust_name varchar(20)not null,city varchar(10)not null,grade int,salesman_id int)
insert into sales values(3002 ,' Nick Rimando',' New York',  100 , 5001)
insert into sales values(3007,' Brad Davis',' New York', 200 , 5001)
insert into sales values(3005,' Graham Zusi','California',  200 , 5002)
insert into sales values(3008 ,' Julian Green ',' London ', 300 , 5002)
insert into sales values(3004 ,' Fabian Johnson', ' Paris ', 300 , 5006)
insert into sales values(3009 ,' Geoff Cameron','Berlin' , 100 ,5003)
insert into sales values(3003 ,' Jozy Altidor' ,'Moscow' , 200 , 5007)
select * from sales where grade=200

-------------------------------------------------------------------------------------------------------
------7-. From the following table, write a SQL query to find the orders, which are delivered by a salesperson
------of ID. 5001. Return ord_no, ord_date, purch_amt.
------ord_no purch_amt ord_date customer_id salesman_id
create table saleman_2(order_no int,purchasing_amt dec(10,2),orde_date date,customer_id int,salesman_id int)
insert into saleman_2 values(70001 ,150.5 ,'2012-10-05', 3005 ,5002)
insert into saleman_2 values(70009, 270.65, '2012-09-10', 3001, 5005)
insert into saleman_2 values(70002, 65.26, '2012-10-05', 3002, 5001)
insert into saleman_2 values(70004 ,110.5, '2012-08-17', 3009 ,5003)
insert into saleman_2 values(70005, 2400.6 ,'2012-07-27', 3007, 5001)
insert into saleman_2 values(70008, 5760 ,'2012-09-10', 3002, 5001)
select * from saleman_2 where salesman_id=5001

-----------------------------------------------------------------------------------------------------------------------------
----8-. From the following table, write a SQL query to find the Nobel Prize winner(s) in the year 1970. Return
----year, subject and winner.
----YEAR ,SUBJECT, WINNER ,COUNTRY, CATEGORY
create table nobel_pri(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_pri values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_pri values (1970,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_pri values (1972,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_pri values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_pri values (1973,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_pri values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_pri(year1,subject1,winner,country) values (1970,' Economics Paul',' Samuelson', 'USA')
select year1,subject1,winner from nobel_pri where year1=1970
delete from nobel_pri where winner=' Hannes Alfven'

----------------------------------------------------------------------------------------------------------------------------
------9- From the following table, write a SQL query to find the Nobel Prize winner in 'Literature' in the year
------1971. Return winner.
------YEAR SUBJECT WINNER COUNTRY CATEGORY

create table nobel_prize(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_prize values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_prize values (1970,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_prize values (1972,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_prize values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_prize values (1973,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_prize values (1971,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_prize(year1,subject1,winner,country) values (1970,' Economics Paul',' Samuelson', 'USA')
select winner from nobel_prize where year1=1971

-----------------------------------------------------------------------------------------------------------------------------------
------10 From the following table, write a SQL query to find the Nobel Prize winner 'Bernard Katz'. Return year,
------subject.
------YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_1(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_1 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_1 values (1970,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_1 values (1972,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_1 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_1 values (1973,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_1 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_1(year1,subject1,winner,country) values (1970,' Economics Paul',' Samuelson', 'USA')
select year1,subject1 from nobel_1 where winner='Bernard Katz'

-------------------------------------------------------------------------------------------------------------------------------
----11 From the following table, write a SQL query to find the Nobel Prize winners in 'Physics' since the year
----1950. Return winner

create table nobel_2(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_2 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_2 values (1950,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_2 values (1972,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_2 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_2 values (1973,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_2 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_2(year1,subject1,winner,country) values (1970,' Economics Paul',' Samuelson', 'USA')
select winner from nobel_2  where year1>=1950 and subject1=' Physics'

-------------------------------------------------------------------------------------------------------------------------------------------
----12 From the following table, write a SQL query to find the Nobel Prize winners in 'Chemistry' between the
----years 1965 to 1975. Begin and end values are included. Return year, subject, winner, and country
----YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_3(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_3 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_3 values (1970,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_3 values (1970,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_3 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_3 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_3 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_3(year1,subject1,winner,country) values (1970,' Economics Paul',' Samuelson', 'USA')
select year1,subject1,winner,country from nobel_3 where year1 between 1965 and 1975
---------------------------------------------------------------------------------------------------------------------------------
------13 . Write a SQL query to show all details of the Physics winners after 1972 of Louis Neel and Ulf von
------Euler .
------YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_4(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_4 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_4 values (1974,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_4 values (1970,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_4 values (1975,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_4 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_4 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_4(year1,subject1,winner,country) values (1970,' Economics Paul',' Samuelson', 'USA')
select*from nobel_4 where year1>1972 and winner=' Louis Neel' or winner='Ulf von Euler'
--------------------------------------------------------------------------------------------------------------------
----14 From the following table, write a SQL query to find the details of the winners whose first name
----matches with the string 'Louis'. Return year, subject, winner, country, and category.
----YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_5(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_5 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_5 values (1970,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_5 values (1970,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_5 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_5 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_5 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_5(year1,subject1,winner,country) values (1970,' Economics Paul',' Samuelson', 'USA')
select * from nobel_5 where winner like ' Louis%'
--------------------------------------------------------------------------------------------------------
----15 From the following table, write a SQL query to combine the winners in Physics, 1970 and in
----Economics, 1971. Return year, subject, winner, country, and category
----YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_7(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_7 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_7 values (1970,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_7 values (1970,'Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_7 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_7 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_7 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_7(year1,subject1,winner,country) values (1971,'Economics','Paul Samuelson', 'USA')
select*from nobel_7 where year1=1970 and subject1=' Physics' or subject1='Economics' and year1=1971

-------------------------------------------------------------------------------------------------------------------------------------
----16 From the following table, write a SQL query to find the Nobel Prize winners in 1970 excluding the
----subjects Physiology and Economics. Return year, subject, winner, country, and category.
----YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_8(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_8 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_8 values (1970,' Physics',' Louis Neel',' France',' Scientist')
insert into nobel_8 values (1970,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_8 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_8 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_8 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_8(year1,subject1,winner,country) values (1971,'Economics','Paul Samuelson', 'USA')

select*from nobel_8 where year1=1970 and subject1 not in ('Physiology','Economics')
--------------------------------------------------------------------------------------------------------------------------------
----17 From the following table, write a SQL query to combine the winners in 'Physiology' before 1971 and
----winners in 'Peace' on or after 1974. Return year, subject, winner, country, and category.
create table nobel_9(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_9 values (1975,'Peace',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_9 values (1970,'Physics',' Louis Neel',' France',' Scientist')
insert into nobel_9 values (1970,'Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_9 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_9 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_9 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_9(year1,subject1,winner,country) values (1971,'Economics','Paul Samuelson', 'USA')

select *from nobel_9 where winner='Physiology' and year1<=1971 and winner='Peace' or year1>1971 

------------------------------------------------------------------------------------------------------------------------------
----18 From the following table, write a SQL query to find the details of the Nobel Prize winner 'Louis Neel'.
----Return year, subject, winner, country, and category.
----YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_10(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_10 values (1970,' Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_10 values (1970,' Physics','Louis Neel',' France',' Scientist')
insert into nobel_10 values (1970,' Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_10 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_10 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_10 values (1970,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_10(year1,subject1,winner,country) values (1970,'Economics','Paul Samuelson', 'USA')

select*from nobel_10 where winner ='Louis Neel'

----------------------------------------------------------------------------------------------------------------------------
----19 From the following table, write a SQL query to find the Nobel Prize winners for the subject started
----with the letter 'P'. Return year, subject, winner, country, and category. Order the result by year,
----descending
----YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_12(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_12 values (1970,'Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_12 values (1975,'Physics','Louis Neel',' France',' Scientist')
insert into nobel_12 values (1972,'Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_12 values (1973,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_12 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_12 values (1975,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_12(year1,subject1,winner,country) values (1971,'Economics','Paul Samuelson', 'USA')

select *from nobel_12 where subject1  like 'P%' order by year1 desc

-------------------------------------------------------------------------------
----20 From the following table, write a SQL query to find the details of 1970 Nobel Prize winners. Order the
----result by subject, Return year, subject, winner, country, and category.
----YEAR SUBJECT WINNER COUNTRY CATEGORY
create table nobel_13(year1 int,subject1 varchar(20),winner varchar(30)not null,country varchar(20),category varchar(20))
insert into nobel_13 values (1970,'Physics',' Hannes Alfven',' Sweden', 'Scientist')
insert into nobel_13 values (1975,'Physics','Louis Neel',' France',' Scientist')
insert into nobel_13 values (1972,'Chemistry','Luis Federico Leloir',' France',' Scientist')
insert into nobel_13 values (1970,'Physiology','Ulf von Euler','Sweden',' Scientist')
insert into nobel_13 values (1970,'Physiology','Bernard Katz','Germany', 'Scientist')
insert into nobel_13 values (1975,'Literature','Aleksandr Solzhenitsyn','Russia', 'Linguist')
insert into nobel_13(year1,subject1,winner,country) values (1971,'Economics','Paul Samuelson', 'USA')

select *from nobel_13 where year1=1970 order by subject1
