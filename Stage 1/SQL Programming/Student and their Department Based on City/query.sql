SELECT s.student_name, d.department_name from Student s
JOIN Department d
ON s.department_id = d.department_id
WHERE s.city = 'Coimbatore'
ORDER BY s.student_name;
