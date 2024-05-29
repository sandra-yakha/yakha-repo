CREATE PROCEDURE [dbo].[UPDATE_Status]
	@Id UNIQUEIDENTIFIER,
	@Status INT
AS
	UPDATE Complaints
	SET
		Status = @Status
	WHERE 
		Id = @Id

RETURN 0