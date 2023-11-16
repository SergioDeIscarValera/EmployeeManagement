using EmployeeManagement.models;
using EmployeeManagement.repositories.employee;
using Newtonsoft.Json;

namespace EmployeeManagement.model
{
    public class DepartmentDto
    {
        [JsonProperty("id")]
        public int Id { get;  set; }
        [JsonProperty("name")]
        public string Name { get;  set; }
        [JsonProperty("employees")]
        public IEnumerable<EmployeeDto> Employees { get; set; }

        public Department ToClass(IRepositoryEmployee repo)
        {
            repo.SaveAll(Employees.Select(e => e.ToClass()));
            return new Department(Id, Name, repo);
        }
    }
}
