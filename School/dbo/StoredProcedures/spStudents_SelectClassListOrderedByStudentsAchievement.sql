CREATE PROCEDURE [dbo].[spStudents_SelectClassListOrderedByStudentsAchievement]
AS
begin
SELECT Name,CLASSMARKAVG FROM dbo.Class 
INNER JOIN
(SELECT ClassId, AVG(CAST(AVGSTUDENT.MARKAVG as Float))  AS CLASSMARKAVG FROM dbo.Students 
INNER JOIN  
(SELECT StudentId, AVG(CAST(Mark as Float)) As MARKAVG
FROM dbo.Subject 
GROUP BY StudentId 
)
AS AVGSTUDENT 
ON dbo.Students.StudentId = AVGSTUDENT.StudentId
GROUP BY ClassId)
AS AVGCLASS
ON dbo.Class.ClassId = AVGCLASS.ClassId
ORDER BY CLASSMARKAVG DESC
;
end
