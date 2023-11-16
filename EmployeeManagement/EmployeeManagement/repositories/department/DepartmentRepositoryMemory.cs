using EmployeeManagement.models;

namespace EmployeeManagement.repositories.deparment;

public class DepartmentRepositoryMemory: IRepositoryDepartment
{
    private readonly Dictionary<int, Department> _departments = new();
    
    public IEnumerable<Department> FindAll() => _departments.Values;

    public Department FindById(int id) => _departments[id];

    public Department Save(Department element) => _departments[element.Id] = element;

    public void SaveAll(IEnumerable<Department> elements) => elements.ToList().ForEach(d => Save(d));

    public bool DeleteById(int id) => _departments.Remove(id);

    public bool Delete(Department element) => DeleteById(element.Id);

    public void DeleteAll() => _departments.Clear();

    public bool ExistsById(int id) => _departments.ContainsKey(id);
}