SELECT W.deptname [Worker Department], W.location [Location], M.deptname [Manager Department] FROM Department W
JOIN Department M
ON W.admrdept = M.deptno
AND W.admrdept != W.deptno
ORDER BY W.deptname;
GO
