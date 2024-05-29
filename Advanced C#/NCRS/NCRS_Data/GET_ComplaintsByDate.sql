CREATE PROCEDURE [dbo].[GET_ComplaintsByDate]
	@StartDate DATETIME,
	@EndDate DATETIME
AS
BEGIN
	SELECT *
	FROM Complaints
	WHERE Date BETWEEN @StartDate AND @EndDate
END
