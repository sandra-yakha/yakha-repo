CREATE PROCEDURE [dbo].[GET_AllComplaintsOrdered]
	
AS
BEGIN
	SELECT  Id, Name, Address, Category, ComplaintDescription, SourceAddress, Date
	FROM Complaints
	ORDER BY Date
END
