-- CREATE CLIENT MASTER TABLE
create table Client_master(
Clientno varchar(6) primary key,
Name varchar(20) not null,
Address1 varchar(30), Address2 varchar(30),
City varchar(15),
Pincode numeric(8), State varchar(15),
Baldue numeric(10,2))

-- CREATE PRODUCT MASTER TABLE
create table Product_master(
Productno varchar(6) primary key,
Description varchar(15) not null, Profitperc numeric(4,2) not null,
Unitmeasure varchar(10) not null, Qtyonhand numeric(8) not null,
Recordlvl numeric(8) not null,
Sellprice numeric(8,2) not null, check (Sellprice>0),
Costprice numeric(8,2) not null check (Costprice>0))

-- CREATE Salesman MASTER TABLE
create table Salesman_master(
Salesmanno varchar(6) primary key, Salesmanname varchar(20) not null,
Address1 varchar(30) not null, Address2 varchar(30),
City varchar(20), Pincode numeric(8), State varchar(20),
Salamt numeric(8,2) not null, check (Salamt>0),
Tgttoget numeric(6,2) not null, Ytdsales numeric(6,2) not null, Remarks varchar(60))

--CREATE sALES ORDER TABLE
create table Sales_order(
Orderno varchar(6) primary key,
Clientno varchar(6) foreign key references Client_master(Clientno),
Orderdate date, Delyaddr varchar(30),
Salesmanno varchar(6) foreign key references Salesman_master(Salesmanno),
Delytype char(1), check (Delytype='P' or Delytype='F'),
Billedyn char(1), check (Billedyn='Y' or Billedyn='N'), Delydate date,
Orderstatus varchar(20),
check (Orderstatus='In process' or Orderstatus='Fulfilled' or Orderstatus='Backorder' or Orderstatus='Cancelled'));

--CREATE sALES ORDER DETAILS TABLE
create table Sales_order_details(
Orderno varchar(6) foreign key references Sales_order(Orderno),
Productno varchar(6) foreign key references Product_master(Productno),
Qtyordered numeric(8), Qtydisp numeric(8), Productrate numeric(10,2),
primary key(Orderno,Productno))
