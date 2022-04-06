SELECT CONCAT(a.lastname, " works for ", b.lastname) AS Hierarchy
FROM (SELECT e.lastname,e.empno,e.job,d.mgrno FROM employee e
JOIN department d ON e.workdept=d.deptno) AS a JOIN
(SELECT e.lastname,e.empno,e.job,d.mgrno FROM employee e 
JOIN department d ON e.workdept=d.deptno) AS b
ON a.mgrno = b.empno
WHERE a.mgrno != a.empno
ORDER BY a.lastname;
GO
