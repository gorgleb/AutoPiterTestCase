CREATE TABLE [dbo].[Students]
(
	[StudentId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(MAX) NULL, 
    [LastName] NVARCHAR(MAX) NULL, 
    [Patronymic] NVARCHAR(MAX) NULL, 
    [ClassId] INT NOT NULL, 
    CONSTRAINT [FK_Students_ToSubject] FOREIGN KEY (ClassId) REFERENCES dbo.Class(ClassId),
)
