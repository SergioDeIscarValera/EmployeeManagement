using EmployeeManagement.model;
using EmployeeManagement.repositories.employee;

namespace EmployeeManagement.models;

public class Department
{
    private static int _count = 0; 
    public int Id { get; private set; }
    public string Name { get; private set; }
    public IRepositoryEmployee ControllerEmployee { get; private set; }
    
    public Department(string name, IRepositoryEmployee controllerEmployee)
    {
        Id = _count++; // Autoincremental
        Name = name;
        ControllerEmployee = controllerEmployee;
    }

    public Department(int id, string name, IRepositoryEmployee controllerEmployee)
    {
        Id = id;
        Name = name;
        ControllerEmployee = controllerEmployee;
    }
    
    public override string ToString()
    {
        return $"Department ({Id}): Name:{Name}";
    }

    public DepartmentDto ToDto()
    {
        return new DepartmentDto
        {
            Id = Id,
            Name = Name,
            Employees = ControllerEmployee.FindAll().Select(e => e.ToDto())
        };
    }
}