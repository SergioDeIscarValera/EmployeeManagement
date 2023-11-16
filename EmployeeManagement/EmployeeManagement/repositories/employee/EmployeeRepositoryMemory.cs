using EmployeeManagement.models;

namespace EmployeeManagement.repositories.employee;

public class EmployeeRepositoryMemory: IRepositoryEmployee
{
    readonly Dictionary<string, Employee> _employees = new ();
    public IEnumerable<Employee> FindAll() => _employees.Values;

    public Employee FindById(string id) => _employees[id];

    public Employee Save(Employee element) => _employees[element.Dni] = element;

    public void SaveAll(IEnumerable<Employee> elements) => 
        elements.ToList().ForEach(e => Save(e));

    public bool DeleteById(string id) => _employees.Remove(id);

    public bool Delete(Employee element) => DeleteById(element.Dni);

    public void DeleteAll() => _employees.Clear();

    public bool ExistsById(string id) => _employees.ContainsKey(id);
    
    public Employee? FindByEmail(string email) => 
        _employees.Values.FirstOrDefault(e => e.Email == email);
}