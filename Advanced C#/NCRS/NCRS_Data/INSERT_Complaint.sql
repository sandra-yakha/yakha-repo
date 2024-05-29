CREATE PROCEDURE [dbo].[INSERT_Complaint]
	@Name NVARCHAR(50),
	@Address NVARCHAR(100),
	@Category INT,
	@ComplaintDescription NVARCHAR(200),
	@SourceAddress NVARCHAR(100)
AS
INSERT INTO Complaints
(Id, Name, Address, Category, ComplaintDescription, SourceAddress, Date, Status)
values
(NEWID(), @Name, @Address, @Category, @ComplaintDescription, @SourceAddress, SYSUTCDATETIME(), 0)


