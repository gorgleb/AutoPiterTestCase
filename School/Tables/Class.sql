CREATE TABLE [dbo].[Class]
(
	[ClassId] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [ClassroomTeacherId] INT NULL, 
    CONSTRAINT [FK_Class_ToClassroomTeacher] FOREIGN KEY (ClassroomTeacherId) REFERENCES dbo.ClassroomTeacher(id) 
)
