                     ---------------database bike store----------------
---------------------->creation store table
CREATE TABLE stores (
store_id INT IDENTITY (1, 1) PRIMARY KEY,
store_name VARCHAR (255) NOT NULL,
phone VARCHAR (25)NOT NULL,
email VARCHAR (255)NOT NULL,
street VARCHAR (255)NOT NULL,
city VARCHAR (255)NOT NULL,
state VARCHAR (10)NOT NULL,
zip_code int
);
insert into stores values('store_1','1234567890','store1@gmail.com','sadar','Nagpur','Maharastra','44011')
insert into stores values('store_2','1234567890','store2@gmail.com','sadar','Nagpur','Maharastra','44012')
insert into stores values('store_3','1234567890','store3@gmail.com','sadar','Nagpur','Maharastra','44013')
insert into stores values('store_4','1234567890','store4@gmail.com','sadar','Nagpur','Maharastra','44014')
insert into stores values('store_5','1234567890','store5@gmail.com','sadar','Nagpur','Maharastra','44015')
insert into stores values('store_6','1234567890','store6@gmail.com','sadar','Nagpur','Maharastra','44016')
insert into stores values('store_7','1234567890','store7@gmail.com','sadar','Nagpur','Maharastra','44017')
insert into stores values('store_8','1234567890','store8@gmail.com','sadar','Nagpur','Maharastra','44018')
insert into stores values('store_9','1234567890','store9@gmail.com','sadar','Nagpur','Maharastra','44019')
insert into stores values('store_10','1234567890','store10@gmail.com','sadar','Nagpur','Maharastra','44020')
select *from stores

-------------------------------------------------------------------------------------------------------------------------------------------------

---> creation of staff table
create table staff(
staff_id int primary key,
first_name varchar(20),
last_name varchar(20),
staff_email varchar(30),
staff_phone bigint,
store_id int constraint st1234 foreign key(store_id)
references stores (store_id),
manager_id int)
insert into staff values(1234,'Gayatri','Sable','staff1@gamil.com',8149947005,1,1021)
insert into staff values(1235,'Gayatri','Sable','staff1@gamil.com',8149947005,2,1022)
insert into staff values(1236,'Gayatri','Sable','staff1@gamil.com',8149947005,3,1023)
insert into staff values(1237,'Gayatri','Sable','staff1@gamil.com',8149947005,4,1024)
insert into staff values(1238,'Gayatri','Sable','staff1@gamil.com',8149947005,5,1025)
insert into staff values(1239,'Gayatri','Sable','staff1@gamil.com',8149947005,6,1026)
insert into staff values(1230,'Gayatri','Sable','staff1@gamil.com',8149947005,7,1027)
insert into staff values(1231,'Gayatri','Sable','staff1@gamil.com',8149947005,8,1028)
insert into staff values(1232,'Gayatri','Sable','staff1@gamil.com',8149947005,9,1029)
insert into staff values(1233,'Gayatri','Sable','staff1@gamil.com',8149947005,10,1030)

select * from staff
select * from stores

------------------------------------------------------------------------------------------------------------------------------
 ---> creation of categories table
create table categories(
category_id int primary key,
category_name varchar(20))
insert into categories values(51,'Sports bike')
insert into categories values(52,'Cruiser')
insert into categories values(53,'Touring')
insert into categories values(54,'Scootr')
insert into categories values(55,'Mountain bike')
insert into categories values(56,'Scootr')
insert into categories values(57,'Chopper')
insert into categories values(58,'Scootr')
insert into categories values(59,'Supermoto')
insert into categories values(60,'Scootr')
select * from categories

----------------------------------------------------------------------------------------------------------------------------------
---> creation of brands table
create table brands(
brand_id int primary key,
brand_name varchar(25))
insert into brands values(321,'Cannonda')
insert into brands values(322,'Hero')
insert into brands values(323,'Honda')
insert into brands values(324,'Bajaj Auto')
insert into brands values(325,'Ktm')
insert into brands values(326,'Honda')
insert into brands values(327,'Honda')
insert into brands values(328,'Royal Enfield')
insert into brands values(329,'Honda')
insert into brands values(330,'Kona')
select * from brands

----------------------------------------------------------------------------------------------------------
---> creation of product table
create table product1 (
product_id int primary key,
product_name varchar(20),
brand_id int constraint b_1 foreign key(brand_id) references brands(brand_id),
category_id int constraint cat1 foreign key(category_id) references categories(category_id) ,
model_year int ,
list_price int)
insert into  product1 values(11,'passion pro',321,51,2022,86000)
insert into  product1 values(12,'splender pro',322,52,2022,83000)
insert into  product1 values(13,'shine',323,53,2022,96000)
insert into  product1 values(14,'unicorn',324,54,2022,120000)
insert into  product1 values(15,'livo',325,55,2022,91000)
insert into  product1 values(16,'unicorn',326,56,2022,120000)
insert into  product1 values(17,'Vespa',327,57,2022,130000)
insert into  product1 values(18,'Pleasere',328,58,2022,100000)
insert into  product1 values(19,'Activa',329,59,2022,110000)
insert into  product1 values(20,'splender',330,60,2022,120000)

select * from product1
select * from brands
select * from categories

-----------------------------------------------------------------------------------------------------------------------------------------
---> creation of customer table
create table customer_1 (
cust_id int primary key,
first_name varchar(20),
last_name varchar(20),
cust_phone bigint,
cust_email varchar(30),
street varchar(20),
city varchar(20),
state varchar(30),
zip_code int)
insert into customer_1 values(131,'Gayatri','Sable',1234567890,'gayatri@gamil.com','sadar','Pune','MH',352656)
insert into customer_1 values(132,'Priyanka','Upadhay',0987654321,'priyanka@gamil.com','LED chowk','Nagpur','MH',352657)
insert into customer_1 values(133,'Megha','Kakde',0986754934,'megha@gamil.com','subhashnagar','Thane','MH',352658)
insert into customer_1 values(134,'Rahul','Dhole',3245769806,'rahul@gamil.com','sadar','Nagpur','MH',352659)
insert into customer_1 values(135,'Om','Sable',4598760342,'om@gamil.com','darda nagar','Wardha','MH',352650)
insert into customer_1 values(136,'Komal','Kakde',0986754934,'komal@gamil.com','subhashnagar','Yavatmal','MH',352658)
insert into customer_1 values(137,'Shivani','Bhad',0986754934,'shivani@gamil.com','subhashnagar','Thane','MH',352658)
insert into customer_1 values(138,'Rajat','Kakde',0986754934,'rajat@gamil.com','subhashnagar','Kolhapur','MH',352658)
insert into customer_1 values(139,'Yash','Dhole',0986754934,'yash@gamil.com','subhashnagar','Mumbai','MH',352658)
insert into customer_1 values(140,'Nikhil','Dod',0986754934,'nikhil@gamil.com','subhashnagar','Nagpur','MH',352658)
select * from customer_1

--------------------------------------------------------------------------------------------------------------------------------------
---> creation of orders table
create table orders(
order_id int primary key,
cust_id int constraint c_1 foreign key(cust_id) references customer_1(cust_id),
order_status varchar(20),
order_date date,
require_date date,
shipping_date date,
store_id int constraint st_1 foreign key(store_id)
references stores (store_id),
staff_id int constraint staff_1 foreign key(staff_id)
references staff(staff_id))

insert into orders values(11,131,'pending','2022-08-21','2022-08-29','2022-09-05',1,1234) 
insert into orders values(12,132,'processing','2022-08-21','2022-08-29','2022-09-05',2,1235) 
insert into orders values(13,133,'rejected','2022-08-21','2022-08-29','2022-09-05',3,1236) 
insert into orders values(14,134,'completed','2022-08-21','2022-08-29','2022-09-05',4,1237) 
insert into orders values(15,135,'pending','2022-08-21','2022-08-29','2022-09-05',5,1238) 
insert into orders values(16,136,'processing','2022-08-21','2022-08-29','2022-09-05',6,1239)
insert into orders values(17,137,'processing','2022-08-21','2022-08-29','2022-09-05',7,1233)
insert into orders values(18,138,'processing','2022-08-21','2022-08-29','2022-09-05',8,1230)
insert into orders values(20,139,'processing','2022-08-21','2022-08-29','2022-09-05',9,1232)
insert into orders values(19,140,'processing','2022-08-21','2022-08-29','2022-09-05',10,1231)
select * from orders
select * from customer_1
select * from staff
select * from stores
------------------------------------------------------------------------------------------------------------------------------
---> creation of order_item table
create table order_item(
order_id int primary key constraint o_1 foreign key(order_id) references orders(order_id),
item_id int, 
product_id int constraint pro_1 foreign key(product_id) references product1(product_id),
quantity int ,
list_price dec(10,2)
)
insert into order_item values(11,10010,11,2,1400)
insert into order_item values(12,101,12,3,1600)
insert into order_item values(13,102,13,5,1900)
insert into order_item values(14,103,14,6,7400)
insert into order_item values(15,104,15,1,300)
insert into order_item values(16,105,16,1,800)
insert into order_item values(17,106,17,1,400)
insert into order_item values(18,107,18,1,600)
insert into order_item values(19,108,20,1,500)
insert into order_item values(20,109,19,1,400)
select * from order_item
select * from product1
select * from orders
-------------------------------------------------------------------------------------------------------------------------------
---> creation of stocks table
create table stocks(
store_id int primary key constraint st_2 foreign key(store_id) references stores (store_id),
product_id int constraint pro_2 foreign key(product_id) references product1(product_id),
quantity int )
insert into stocks values(1,11,800)
insert into stocks values(2,12,1800)
insert into stocks values(3,13,8900)
insert into stocks values(4,14,600)
insert into stocks values(5,15,900)
insert into stocks values(6,16,8900)
insert into stocks values(7,17,8900)
insert into stocks values(8,18,8900)
insert into stocks values(9,19,8900)
insert into stocks values(10,20,8900)
select * from stocks
select * from stores
select * from product1