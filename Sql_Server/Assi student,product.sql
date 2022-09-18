--1- create a databse mkpits1
--2- create a table student having columns rno,name,address,mobno
--3- insert at least 10 records into student table
--4- write a query to view all records

create table student3(rno int,name varchar(20),address varchar(100),mobileno bigint)
insert into student3 values(11,'Amit','Flat no.346',8149947005)
insert into student3 values(12,'Neha','Flat no.347',8149976989)
insert into student3 values(13,'Nikita','Flat no.348',5678700598)
insert into student3 values(14,'Gayatri','Flat no.349',849987005)
insert into student3 values(15,'Ram','Flat no.350',8149947005)
insert into student3 values(16,'Priyanka','Flat no.351',814994005)
insert into student3 values(17,'om','Flat no.352',814547005)
insert into student3 values(18,'Achal','Flat no.353',8677947005)
insert into student3 values(19,'Shivani','Flat no.354',3455699405)
insert into student3 values(20,'Maya','Flat no.355',455947005)
select * from student3
delete from student3 

--5- create a table customers having columns custid,custname,custaddress
--6- insert 10 records
--7- view all records

create table customers(custid int primary key,custname varchar(20),custadd varchar(30))
insert into customers values(1,'Ram','House no. 34')
insert into customers values(11,'Neha','House no. 37')
insert into customers values(31,'Mina','House no. 39')
insert into customers values(71,'Gayatri','House no. 33')
insert into customers values(41,'Om','House no. 35')
select*from customers
delete from customers

--8- create a table users having column userid, username, password1,emailid,gender,city,country
--9- insert 10 records of different users
--10 -view all records


create table users9(useid int primary key,username varchar(20),userpass varchar(30),useremailid varchar(20),usergender varchar(56),usercity varchar(50), country varchar(78))
insert into users9 values(21,'Ram','ram123','ram@123','male','Nagpur','India')
insert into users9 values(65,'Gayatri','Gayatri123','gayatri@123','female','Nagar','India')
insert into users9 values(45,'om','Om123','om@123','male','Thane','India')
insert into users9 values(98,'mina','mina123','mina@123','female','Nagpur','India')
insert into users9 values(99,'Neha','neha123','neha@123','female','Delhi','India')
insert into users9 values(22,'nikita','nikita123','nikita@123','female','nagpur','India')
insert into users9 values(23,'amit','amit123','amit@123','male','Mumbai','India')
insert into users9 values(25,'mona','mona123','mona@123','female','Bhopal','India')
insert into users9 values(29,'Riya','riya123','riya@123','female','Pune','India')
insert into users9 values(20,'Radhika','Radhika123','radhika@123','female','Nagpur','India')
select*from users9