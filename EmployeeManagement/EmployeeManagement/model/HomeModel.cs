using EmployeeManagement.models;
using EmployeeManagement.repositories.deparment;

namespace EmployeeManagement.model
{
    internal class HomeModel
    {
        public IRepositoryDepartment Departments { get; set; }

        public Department? DepartmentSelected { get; set; }
        public Employee? EmployeeSelected { get; set; }
        
        public HomeModel(IRepositoryDepartment departments)
        {
            Departments = departments;
        }
    }
}
