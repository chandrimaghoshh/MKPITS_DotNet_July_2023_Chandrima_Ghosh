select * from product

create function fun_pro
(@ProdName nvarchar(50),@ProdModel_Year nvarchar(50))
returns nvarchar(100)
as begin
return (select @ProdName + ' , ' + @ProdModel_Year)
end

select 
dbo.fun_pro(product_name,model_yr)as 'Details' from product