using EmployeeManagement.models;

namespace EmployeeManagement.repositories.employee;

public interface IRepositoryEmployee: ICrudRepository<Employee, string>
{
    Employee? FindByEmail(string email);
}