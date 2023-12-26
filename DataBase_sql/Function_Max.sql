create table products(productName varchar(20),Quantity int,Price int)

insert into products values('Microwave',2,20000),('Fridge',1,50000),('Mixer',3,15000)

select * from products

   SELECT productName, Quantity, Price  
    FROM products 
    WHERE Quantity = (  
    SELECT MAX(Quantity) AS "Maximum Quantity"   
    FROM products); 

	 SELECT productName, MAX(Quantity) AS "Maximum Quantity"   
    FROM products 
    GROUP BY productName  
    ORDER BY productName 