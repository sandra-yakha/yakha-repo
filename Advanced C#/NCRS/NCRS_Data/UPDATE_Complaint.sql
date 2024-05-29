CREATE PROCEDURE [dbo].[UPDATE_Complaint]
	@Id UNIQUEIDENTIFIER,
	@Name NVARCHAR(50),
	@Address NVARCHAR(100),
	@Category INT,
	@ComplaintDescription NVARCHAR(200),
	@SourceAddress NVARCHAR(100),
	@Status INT
AS
	UPDATE Complaints
	SET
		Name = @Name,
		Address = @Address,
		Category = @Category,
		ComplaintDescription = @ComplaintDescription,
		SourceAddress = @SourceAddress,
		Status = @Status
	WHERE 
		Id = @Id

RETURN 0
