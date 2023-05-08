INSERT INTO Client_master (Clientno, Name, City, Pincode, State, Baldue)
VALUES ('1', 'Ram', 'Mumbai', 400054, 'Maharashtra', 15000),
		('2', 'Sam', 'Hyd', 500016, 'TS', 25000),
		('3', 'Jam', 'Guntur', 522408, 'AP', 55000),
		('4', 'Gam', 'Trivandrum', 695583, 'Kerala', 5000),
		('5', 'Kim', 'Kanyakumari', 700017, 'TN', 11000);
select * from Client_master

--Product Master
INSERT INTO Product_Master 
VALUES ('P1', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250),
	   ('P2', 'Shirts', 4, 'Piece', 150, 40, 250, 300),