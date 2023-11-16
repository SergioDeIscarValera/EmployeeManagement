using EmployeeManagement.model;

namespace EmployeeManagement.models;

public class Employee
{
    public string Dni { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public string Position { get; private set; }
    
    public Employee(string dni, string name, string email, string phone, string position)
    {
        Dni = dni;
        Name = name;
        Email = email;
        Phone = phone;
        Position = position;
    }

    public override string ToString()
    {
        return
            $"Employee ({Dni}): Name:{Name}, Email:{Email}, Phone:{Phone}, Position:{Position}";
    }

    public EmployeeDto ToDto()
    {
        return new EmployeeDto
        {
            Dni = Dni,
            Name = Name,
            Email = Email,
            Phone = Phone,
            Position = Position
        };
    }
}