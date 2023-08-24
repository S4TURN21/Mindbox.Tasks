USE MindboxDb;
GO
SELECT p.Name as ProductName, c.Name AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON c.Id = pc.CategoryId