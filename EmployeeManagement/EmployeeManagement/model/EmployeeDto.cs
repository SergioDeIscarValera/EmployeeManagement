using EmployeeManagement.models;
using Newtonsoft.Json;

namespace EmployeeManagement.model
{
    public class EmployeeDto
    {
        [JsonProperty("dni")]
        public string Dni { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }

        public Employee ToClass()
        {
            return new Employee(Dni, Name, Email, Phone, Position);
        }
    }
}
