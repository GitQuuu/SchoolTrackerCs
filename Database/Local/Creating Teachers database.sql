CREATE TABLE [dbo].[Teachers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NCHAR(50) NOT NULL, 
    [address] NVARCHAR(50) NOT NULL, 
    [CPR] INT NOT NULL, 
    [phoneNumber] INT NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [specials] NVARCHAR(50) NOT NULL, 
    [salary] DECIMAL NOT NULL
)