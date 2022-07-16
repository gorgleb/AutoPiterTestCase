CREATE TABLE [dbo].[Subject]
(
	[StudentId] INT NOT NULL PRIMARY KEY, 
    [Mark] INT NULL, 
    [Date] DATETIME2 NULL, 
    CONSTRAINT [FK_Subject_ToStudent] FOREIGN KEY (StudentId) REFERENCES dbo.Students(StudentId)
)
