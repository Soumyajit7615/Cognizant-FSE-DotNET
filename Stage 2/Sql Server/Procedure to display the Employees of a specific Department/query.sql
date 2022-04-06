CREATE PROCEDURE EmployeesDept
@DeptNo VARCHAR
AS
BEGIN

	SELECT lastname AS Name FROM Employee
	WHERE workdept = 'D21'

END
GO
