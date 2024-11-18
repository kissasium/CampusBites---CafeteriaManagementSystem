---- DROP TABLE STATEMENTS
--DROP TABLE IF EXISTS UserSignUpLog;
--DROP TABLE IF EXISTS OrderHistory;
--DROP TABLE IF EXISTS Feedback;
--DROP TABLE IF EXISTS itemINCLUDEDcartItems;
--DROP TABLE IF EXISTS payment;
--DROP TABLE IF EXISTS CartItem;
--DROP TABLE IF EXISTS OrderCart;
--DROP TABLE IF EXISTS currentitem;
--DROP TABLE IF EXISTS currentcustomer;
--DROP TABLE IF EXISTS pointsEARNEDprogram;
--DROP TABLE IF EXISTS customerPoints;
--DROP TABLE IF EXISTS programOFFERSrewards;
--DROP TABLE IF EXISTS rewards;
--DROP TABLE IF EXISTS programOFFERSrewards;
--DROP TABLE IF EXISTS categoryBELONGSmenu;
--DROP TABLE IF EXISTS menuHASitem;
--DROP TABLE IF EXISTS categoryHASitem;
--DROP TABLE IF EXISTS item;
--DROP TABLE IF EXISTS category;
--DROP TABLE IF EXISTS loyaltyProgram;
--DROP TABLE IF EXISTS loyaltyProgram;
--DROP TABLE IF EXISTS inventory;
--DROP TABLE IF EXISTS staff;
--DROP TABLE IF EXISTS currentstaff;
--DROP TABLE IF EXISTS vendor;
--DROP TABLE IF EXISTS menu;
--DROP TABLE IF EXISTS administrator;
--DROP TABLE IF EXISTS customer;
--DROP TABLE IF EXISTS users;

--------------------------------------------------------------------------------------------------------------------------------------
create table users (
	userID int primary key Identity(1,1),
	first_name varchar(255),
	last_name varchar(255),
	email varchar(255),
	password varchar(255),
	phonenumber varchar(255),
	usertype varchar(255) CHECK (usertype in ('customer', 'staff', 'administrator')),
	CONSTRAINT checkphonenumber CHECK (phonenumber LIKE '+%'),
);

CREATE TABLE UserSignUpLog (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT,
    Action VARCHAR(50),
    Timestamp DATETIME,
    CONSTRAINT FK_UserAuditLog_UserID FOREIGN KEY (UserID) REFERENCES users(userID)
);

create table administrator (
	userID int primary key,
	adminID int Identity(1,1),
	foreign key (userID) references users(userID)
);

create table customer (
	userID int primary key,
	customerID int Identity(1,1),		--just to see which number customer
	adminID int,
	foreign key (userID) references users(userID),
	foreign key (adminID) references administrator(userID)
);

create table inventory (
	inventoryID int primary key Identity(1,1),
	iname varchar(255),
	currentQuantity int,			--existing number of item
	reorderquantity int,	--the (total) number of products you order from a supplier
	unitprice decimal(10,2),
	adminID int,
	foreign key (adminID) references administrator(userID)
);

create table vendor (
	vendorID int primary key Identity(1,1),
	first_name varchar(255),
	last_name varchar(255),
	email varchar(255),
	phonenumber varchar(255),
	inventoryID int,
	CONSTRAINT checknumber CHECK (phonenumber LIKE '+%' AND LEN(phonenumber) = 13),
	foreign key (inventoryID) references inventory(inventoryID)
);

create table staff (
	userID int primary key,
	staffID int Identity(1,1),
	srole varchar(255) CHECK (srole in ('employee', 'cafe manager', 'cashier', 'cook')),	--ppl behind the counter can just be called employees
	hourswork varchar(255),
	adminID int,
	inventoryID int,
	foreign key (userID) references users(userID),
	foreign key (adminID) references administrator(userID),
	foreign key (inventoryID) references inventory(inventoryID),
);

create table currentstaff (
	 id int primary key identity(1,1),
	 staffid int,
);

create table menu (
	menuID int primary key Identity(1,1),
	adminID int,
	staffID int,
	foreign key (adminID) references administrator(userID),
	foreign key (staffID) references staff(userID),
);

create table category (
	categoryID int primary key ,
	cname varchar(255),
	totalAmt int,		--how many items in a category
	availibiltystatus varchar(255) CHECK ( availibiltystatus in ('available', 'not available')),
	inventoryID int,
	foreign key (inventoryID) references inventory(inventoryID),
);

create table loyaltyProgram (
	programID int primary key,
	name varchar(255),
	adminID int,
	foreign key (adminID) references administrator(userID)
);

create table item (
	itemID int primary key identity(1,1),
	itemName varchar(255),
	price int
);

create table menuHASitem (
	id int primary key Identity(1,1),
	menuID int,
	itemID int,
	foreign key (menuID) references menu(menuID),
	foreign key (itemID) references item(itemID)
);

create table categoryBELONGSmenu (
	id int primary key identity(1,1),
	menuID int,
	categoryID int,
	foreign key (menuID) references menu(menuID),
	foreign key (categoryID) references category(categoryID)
);

create table rewards (
	rewardID int primary key,
	rewardDescription varchar(255),
	pointRequirement varchar(255)
);

create table programOFFERSrewards (
	id int primary key identity(1,1),
	rewardID int,
	programID int,
	foreign key (rewardID) references rewards(rewardID),
	foreign key (programID) references loyaltyProgram(programID)	
);

create table customerPoints (
	pointsID int primary key identity(1,1),
	totalpoints int,
	customerID int,
	foreign key (customerID) references customer(userID)
);

create table pointsEARNEDprogram (
	id int primary key identity(1,1),
	programID int,
	pointsID int,
	foreign key (programID) references loyaltyProgram(programID),
	foreign key (pointsID) references customerPoints(pointsID)
);

create table currentcustomer
(
     id int primary key identity(1,1), 
     customerid int
);
create table currentitem
(
     id int primary key identity(1,1), 
     itemid int
);

CREATE TABLE OrderCart (
    CartID int PRIMARY KEY identity (1,1),
    CustomerID int,
    DateCreated datetime,
    TotalPrice decimal(10,2),
    FOREIGN KEY (CustomerID) REFERENCES customer(userID)
);


CREATE TABLE CartItem (
    CartItemID int PRIMARY KEY identity (1,1),
    CartID int,
    ItemID int,
    Quantity int,
    ItemPrice decimal(10,2),
    FOREIGN KEY (CartID) REFERENCES OrderCart(CartID),
    FOREIGN KEY (ItemID) REFERENCES item(itemID)
);

create table payment (
	paymentID int primary key identity(1,1),
	amount decimal(10,2),
	method varchar(255) CHECK (method in ( 'credit card', 'cash', 'debit card')),
	transactionDate varchar(255),
	CartID int,
	foreign key (CartID) references OrderCart(CartID)
);

create table Feedback (
	id int primary key identity(1,1),
	feedback varchar(255),
	customerID int,	
	foreign key (customerID) references customer(userID),
);

CREATE TABLE OrderHistory (
	id int primary key identity(1,1),
    CartID INT,
    CustomerID INT,
    itemID INT,
    Quantity INT,
    TotalPrice DECIMAL(10, 2),
    OrderDate DATETIME,
    FOREIGN KEY (CartID) REFERENCES OrderCart(CartID), 
    FOREIGN KEY (CustomerID) REFERENCES customer(userID), 
    FOREIGN KEY (itemID) REFERENCES item(itemID) 
);

CREATE TABLE categoryHASitem (
    id int PRIMARY KEY IDENTITY(1,1),
    categoryID int,
    itemID int,
    FOREIGN KEY (categoryID) REFERENCES category(categoryID),
    FOREIGN KEY (itemID) REFERENCES item(itemID)
);


--------------INSERTING DATA-------------------------
--Insert 10 users
INSERT INTO users VALUES
('Ted', 'Mosby', 'ted@hotmail.com', 'ted123', '+987654321', 'administrator'),	--1--admin
('Sara', 'Johnson', 'sara@gmail.com', 'sara123','+923450987654', 'staff'),		--2--cafe manager
('Jay', 'Dashri', 'Jay@gmail.com', 'jay123' , '+912346789', 'customer'),--3
('Ahmed', 'Khan', 'ahmed@hotmail.com','ahmed123', '+923451234567', 'customer'),--4
('Ali', 'Mohammed', 'ali@gmail.com', 'ali123','+923459876543', 'customer'),--5
('Emily', 'Davis', 'emily@outlook.com', 'emily123','+92459876543', 'staff'),--6
('Mehmet', 'Yang', 'mehmet@gmail.com','mehmet123', '+905551234567', 'staff'),--7
('Sophia', 'Lee', 'sophia@outlook.com','sophia123', '+123450123456', 'staff'),--8
('Raj', 'Patel', 'raj@outlook.com', 'raj123','+919876543210', 'staff'),--9
('Isabella', 'Garcia', 'isabella@hotmail.com', 'isabella123','+123459876543', 'staff'),--10
('Hamna', 'Rizwan', 'hamna@gmail.com', 'hamna123','+123459876543', 'customer');--11


--Insert into adminstrator table
INSERT INTO administrator VALUES 
(1);

--Insert into customer table
INSERT INTO customer VALUES 
(3, 1),
(4, 1),
(5, 1),
(11, 1);

--Insert into inventory table
INSERT INTO inventory VALUES
('Inventory1', 100, 50, 10.00, 1);

--Insert into vendor table
INSERT INTO vendor VALUES
('Jahnvi', 'J&ShareefCo', 'J&Shareef@gmail.com', '+927654321232',1),
('Karanvir', 'KSuppliyMart', 'KSuppliyMart@gmail.com', '+923450987654',1);

--Staff
INSERT INTO staff  VALUES
(2, 'cafe manager','20 hours',1 ,1),
(6, 'employee','10 hours', 1, 1),
(7, 'cook','15 hours ', 1, 1),
(8, 'cashier','13 hours', 1, 1);

--Menu
INSERT INTO menu VALUES 
(1, 6),
(1, 7);

--Categories
INSERT INTO category VALUES 
(3,'Beverage', 6, 'available', 1),
(4,'Meals', 6, 'available', 1),
(5,'Breakfast', 4, 'available', 1),
(6,'Snacks', 4, 'available', 1),
(7,'Dessert', 4, 'available', 1),
(8,'Cafe', 4, 'available', 1);

--Loyalty Program
INSERT INTO loyaltyProgram VALUES 
(0, 'No Membership', 1),
(1, 'Silver Membership', 1), 
(2, 'Gold Membership', 1);

-- Item
INSERT INTO item VALUES 
('Big Apple', 100), 
('Biryani', 250), 
('Karak Chai', 70),
('Milo', 110);

INSERT INTO item VALUES 
('Coke', 170);

INSERT INTO item VALUES 
('Fanta', 170);

INSERT INTO item VALUES 
( 'Sprite', 170),
( 'Orange Juice', 180),
( 'Iced Tea', 190);

INSERT INTO item VALUES 
( 'BBQ Wrap', 180),
( 'Chicken Pulao', 220),
( 'Krispy Deal', 220),
( 'Chicken Fajita', 180),
('Chicken Biryani', 220),
('Friends Deal', 440);

INSERT INTO item VALUES 
( 'Waffles', 200),
( 'Halwa Puri', 180),
( 'Paratha', 110),
( 'Pancakes', 200);

INSERT INTO item VALUES 
( 'Nuggets', 200),
( 'Samosa', 100),
( 'Gol Gappay', 110),
( 'Fries', 120);

INSERT INTO item VALUES 
( 'Donut', 180),
( 'Brownie', 180),
( 'Cookie', 180),
( 'Macaron', 200);

INSERT INTO item VALUES 
( 'Coffee', 180),
( 'Green Tea', 50),
( 'Iced Mocha', 180);

-- Menu Has Item
INSERT INTO menuHASitem VALUES
(1, 1),
(2, 2), 
(2, 3);

-- Category Belongs Menu
INSERT INTO categoryBELONGSmenu VALUES
(1, 3),
(1, 4);

INSERT INTO categoryBELONGSmenu VALUES
(1,	5),
(1,	6),
(1,	7),
(1,	8);

-- Rewards
INSERT INTO rewards VALUES 
(1, '5% discount on all orders', '10000 points'), 
(2, '10% discount on all orders', '100000 points');

-- Program Offers Rewards
INSERT INTO programOFFERSrewards VALUES 
(1, 1), 
(2, 2);

-- Customer Points
INSERT INTO customerPoints VALUES 
(10, 3), 
(25, 4),
(50, 5),
(0, 11);

-- Points Earned Program
INSERT INTO pointsEARNEDprogram VALUES 
(1, 1), 
(2, 2);

-- OrderCart
INSERT INTO OrderCart (CustomerID, DateCreated, TotalPrice) VALUES
(3, '2023-04-01 10:00:00', 0),  -- Cart for customer with ID 3
(4, '2023-04-01 11:30:00', 0),  -- Cart for customer with ID 4
(11, '2023-04-01 11:30:00', 0);

-- Payment
INSERT INTO payment VALUES 
(20.00, 'credit card', '2023-01-02', 1), 
(45.00, 'cash', '2023-01-03', 2);

-- CartItem
INSERT INTO CartItem (CartID, ItemID, Quantity, ItemPrice) VALUES
(1, 1, 4, 20.00),  
(1, 2, 2, 50.00), 
(2, 1, 3, 20.00), 
(2, 2, 1, 50.00);  

-- CategoryHASitem
insert into categoryHASitem values
(3,1),
(4,2),
(8,3),
(3,4),
(3,5),
(3,6),
(3,7),
(3,8),
(3,9),
(8,9),
(4,10),
(4,11),
(4,12),
(4,13),
(4,14),
(4,15),
(5,16),
(5,17),
(5,18),
(5,19),
(6,20),
(6,21),
(6,22),
(6,23),
(7,24),
(7,25),
(7,26),
(7,27),
(8,28),
(8,29),
(8,30);