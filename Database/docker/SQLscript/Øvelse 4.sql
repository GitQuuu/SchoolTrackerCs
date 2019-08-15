CREATE TABLE [dbo].[Car]
(
	[CarID] INT NOT NULL IDENTITY, 
    [Registration No.] NVARCHAR(7) NOT NULL, 
    [Manufactor] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Production year] INT NOT NULL, 
    [Owner] NCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Car] PRIMARY KEY ([Registration No.], [CarID]) 
)