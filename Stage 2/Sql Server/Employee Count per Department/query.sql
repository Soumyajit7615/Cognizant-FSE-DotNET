CREATE PROCEDURE EmployeeCount
@deptno CHAR(3),
@total_employees INT OUTPUT
AS
BEGIN

	SELECT @total_employees = COUNT(empno) FROM Employee 
							  WHERE workdept = @deptno
	return @total_employees

END
GO
