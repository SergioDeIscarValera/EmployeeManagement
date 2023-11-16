using EmployeeManagement.models;

namespace EmployeeManagement.view
{
    public delegate void CallBackString(string employeeDni);
    public delegate void CallBackEmployee(Employee employee);
    public delegate void CallBackInt(int departmentId);

    internal interface IHomeView
    {
        public event CallBackInt OnDepartmentSelected;

        public event CallBackString OnEmployeeSelected;

        public event CallBackEmployee OnEmployeeAdded;
        public event CallBackEmployee OnEmployeeUpdated;
        public event EventHandler OnEmployeeDeleted;

        public event CallBackString LoadFile;
        public event CallBackString SaveFile;

        void SetDepartments(IEnumerable<Department> value);

        void SetDepartmentSelected(Department value);

        void SetEmployeeSelected(Employee value);
    }
}
