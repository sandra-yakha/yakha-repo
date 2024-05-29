CREATE PROCEDURE [dbo].[GET_ComplaintsByName]
	@Name NVARCHAR(50)
AS
BEGIN
	SELECT  Id, Name, Address, Category, ComplaintDescription, SourceAddress, Date
	FROM Complaints
	WHERE Name LIKE '%' + @Name + '%'
END
