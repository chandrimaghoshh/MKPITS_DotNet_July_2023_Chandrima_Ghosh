create table product(id int primary key,name varchar(20),
price int, quantity int)

 INSERT INTO Product VALUES(111, 'Mobile', 10000, 10),  
    (112, 'Laptop', 20000, 15),  
    (113, 'Mouse', 300, 20),  
    (114, 'Hard Disk', 4000, 25),  
    (115, 'Speaker', 3000, 20);  

	select * from product

	-- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
     INSERT INTO Product VALUES(116, 'Headphone', 2000, 30)  
     UPDATE Product SET Price = 450 WHERE id = 113  
     -- Commit changes   
    COMMIT TRANSACTION  

	 BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product SET Price = 5000 WHERE id = 114  
    DELETE FROM Product WHERE id = 116 

	  -- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product SET Price = 5000 WHERE id = 114  
    DELETE FROM Product WHERE id = 116  
    --Undo Changes  
    ROLLBACK TRANSACTION 