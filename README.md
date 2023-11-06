SELECT
    p.ProductName AS "Имя продукта",
    COALESCE(c.CategoryName, 'Without Category') AS "Имя категории"
FROM
    Product p
LEFT JOIN
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN
    Categories c ON pc.CategoryID = c.CategoryID;