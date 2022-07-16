CREATE PROCEDURE [dbo].[spStudents_SelectTheExcellents]
AS
begin
	SELECT StudentId FirstName,LastName, Patronymic
	FROM dbo.Students
	WHERE StudentId IN (
	SELECT StudentId	
	FROM dbo.Subject 
	GROUP BY StudentId HAVING MIN(Mark)>3)  
	;
end
