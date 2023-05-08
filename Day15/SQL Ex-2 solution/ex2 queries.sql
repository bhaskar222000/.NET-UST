--1. Display the names of all the clients.

select Name from Client_Master;

--2. Display all the clients who are located in Mumbai.

select * from Client_Master where City='Mumbai';

--3. Display all the products whose selling price is > 2000 and < 5000.

select * from Product_Master where Sellprice>200 and Sellprice<500 ;

--4. Display Name, City and State of Clients not in the state of Maharashtra.

select Name,City,State from Client_Master where State!='Maharashtra';

--5. Display all the information of client_no C1 and C2.

select * from Client_Master where ClientNo in('1','2');

--6. Change the selling price of '1.44 drive' to Rs. 1150.50.

update Product_Master set Sellprice=1.44 where Sellprice=1150.50

--7. Delete the record of client_no C0005.

delete Client_Master where Clientno='5';

--8. Display the clients who stay in a city whose second letter is 'a'.

select * from Client_Master where city like '_a%';

--9. Count the number of products having price greater than or equal to 1500.

select count(Productno) as NUMBER_OF_PRODUCTS from Product_Master where Sellprice>=1500;

--10. Display qtyordered, qtydisp and balancedqty (not in table)

select Qtyordered,Qtydisp as Balancedqty from Sales_Order_Details;

