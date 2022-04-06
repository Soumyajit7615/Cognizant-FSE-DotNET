DECLARE @dept_name VARCHAR(max), @empcount VARCHAR(max);

DECLARE dpt_cur CURSOR FOR
SELECT COUNT(e.workdept), d.deptname
FROM Department d JOIN Employee e
ON d.deptno = e.workdept
GROUP BY e.workdept,d.deptname
ORDER BY d.deptname;
open dpt_cur;

fetch next FROM dpt_cur into
@empcount,
@dept_name;
While @@fetch_status = 0

BEGIN
    IF(@empcount > 1)
    print @dept_name+"department has"+cast(@empcount as varchar)+"employees";
    fetch next FROM dpt_cur into
    @empcount,
    @dept_name;
END;
CLOSE dpt_cur;
DEALLOCATE dpt_cur;
GO
