using EmployeeManagement.model;
using EmployeeManagement.presenters;
using EmployeeManagement.repositories.deparment;
using EmployeeManagement.view;

namespace EmployeeManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            HomeModel model = new(new DepartmentRepositoryMemory());

            HomeView view = new();

            new HomePresenter(view, model);

            Application.Run(view);
        }
    }
}