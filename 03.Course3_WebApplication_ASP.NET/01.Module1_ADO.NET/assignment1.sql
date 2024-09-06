Create Database  Sept2024Db
CREATE TABLE Product_table
(
	pid INT PRIMARY KEY, 
	pname VARCHAR(10),
	price int,	
	quantity INT,	
	category VARCHAR(20)
)

INSERT INTO Product_table VALUES(7369,'Prawns',800, 20,'Seafood');
INSERT INTO Product_table VALUES(7499,'Chicken',1600,30,'Poultry');
INSERT INTO Product_table VALUES(7521,'Corn',1250,30, 'Vegrtation');
INSERT INTO Product_table VALUES(7566,'Lays',2975,20,'Junk');
INSERT INTO Product_table VALUES(7654,'Kurkure',1250,30,'Junk');
INSERT INTO Product_table VALUES(7698,'Dal',2850,30,'Cereals');

select *from Product_table