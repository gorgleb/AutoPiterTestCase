CREATE PROCEDURE [dbo].[spStudents_SelectAverageStudents]
AS
begin
SELECT StudentId, FirstName,LastName, Patronymic
FROM dbo.Students
WHERE StudentId IN (
SELECT StudentId
FROM dbo.Subject 
GROUP BY StudentId HAVING AVG(CAST(Mark as Float))>3.5 AND AVG(CAST(Mark as Float))<4.5 )  
;
end