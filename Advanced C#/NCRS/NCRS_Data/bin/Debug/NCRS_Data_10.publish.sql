﻿/*
Deployment script for NCRS_Data

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "NCRS_Data"
:setvar DefaultFilePrefix "NCRS_Data"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating Procedure [dbo].[INSERT_Complaint]...';


GO
CREATE PROCEDURE [dbo].[INSERT_Complaint]
	@Name NVARCHAR(50),
	@Address NVARCHAR(100),
	@Category INT,
	@ComplaintDescription NVARCHAR(200),
	@SourceAddress NVARCHAR(100)

AS
INSERT INTO Complaint 
(Name, Address, ComplaintDescription, Category, SourceAddress)
values
(NEWID(), @Name, @Address, @Category, @ComplaintDescription, @SourceAddress, SYSUTCDATETIME(), 0)
GO
PRINT N'Update complete.';


GO
