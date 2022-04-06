SELECT E.firstname, E.lastname, E.salary FROM Employee E
JOIN Department D
ON E.workdept = D.deptno
WHERE D.location = 'New York'
ORDER BY E.firstname
GO
