SELECT prod.name as ProductName, c.name as CategoryName FROM Product prod
LEFT JOIN ProductCategory prodCategory on prod.id = prodCategory.product_id
LEFT JOIN Category c on prodCategory.category_id = c.id