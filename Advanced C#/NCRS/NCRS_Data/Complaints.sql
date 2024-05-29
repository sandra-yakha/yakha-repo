CREATE TABLE [dbo].[Complaints]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(100) NOT NULL, 
    [Category] INT NOT NULL, 
    [ComplaintDescription] NVARCHAR(200) NULL, 
    [SourceAddress] NVARCHAR(100) NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [Status] INT NOT NULL
)
