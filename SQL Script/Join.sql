
SELECT Id as EmployeeID, Name, Department, City, Title as Project, ClientId
FROM Employee 
INNER JOIN Projects 
ON Employee.Id = Projects.EmployeeId;

Select * from Employee;
Select * from Projects;

SELECT *
FROM Employee 
INNER JOIN Projects 
ON Employee.Id = Projects.EmployeeId;

Select * From Employee
Left Join Projects
On Employee.Id=Projects.ProjectId;