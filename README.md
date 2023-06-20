# TestWorkMB

Задача 1

Сделал на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Задача 2

SELECT prod.name as ProductName, c.name as CategoryName FROM Product prod
LEFT JOIN ProductCategory prodCategory on prod.id = prodCategory.product_id
LEFT JOIN Category c on prodCategory.category_id = c.id
