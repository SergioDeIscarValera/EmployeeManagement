using EmployeeManagement.model;
using EmployeeManagement.models;
using EmployeeManagement.repositories.employee;
using EmployeeManagement.utils;
using EmployeeManagement.view;
using Newtonsoft.Json;

namespace EmployeeManagement.presenters
{
    internal class HomePresenter
    {
        private readonly IHomeView view;
        private readonly HomeModel model;


        public HomePresenter(IHomeView view, HomeModel model)
        {
            this.view = view;
            this.model = model;

            view.OnDepartmentSelected += View_OnDepartmentSelected;
            view.OnEmployeeSelected += View_OnEmployeeSelected;

            view.OnEmployeeAdded += View_OnEmployeeAdded;
            view.OnEmployeeUpdated += View_OnEmployeeUpdated;
            view.OnEmployeeDeleted += View_OnEmployeeDeleted;

            view.LoadFile += View_LoadFile;
            view.SaveFile += View_SaveFile;

            LoadDepartmets();
        }

        private void LoadDepartmets()
        {
            var defaultPath = Utils.GetInstance().GetDefaultPath();
            View_LoadFile(defaultPath.Key + defaultPath.Value);

            if (!model.Departments.FindAll().Any())
            {
                model.Departments.SaveAll(Utils.GetInstance().GetDefaultDepartments());
                view.SetDepartments(model.Departments.FindAll()); // Actualizar la lista de departamentos
            }
        }

        private void View_OnEmployeeDeleted(object? sender, EventArgs e)
        {
            if (!ValidateDepartmentSelected() || !ValidateEmployeeSelected()) return;

            var result = model.DepartmentSelected!.ControllerEmployee.Delete(model.EmployeeSelected!);

            if (result)
            {
                MessageBox.Show("Se elimino el empleado " + model.EmployeeSelected.Name);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el empleado " + model.EmployeeSelected.Name);
            }

            view.SetDepartmentSelected(model.DepartmentSelected); // Actualizar la lista de empleados
        }

        private void View_OnEmployeeUpdated(Employee newEmployee)
        {
            if (!ValidateDepartmentSelected() || !ValidateEmployeeSelected()) return;
            // Es el repositorio el que se encarga de segregar si es un nuevo empleado o uno existente.
            var result = model.DepartmentSelected!.ControllerEmployee.Save(newEmployee);

            if (result is null)
            {
                MessageBox.Show("No se pudo actualizar el empleado " + newEmployee.Name);
            }
            else
            {
                MessageBox.Show("Se actualizo el empleado " + newEmployee.Name);
            }

            view.SetDepartmentSelected(model.DepartmentSelected); // Actualizar la lista de empleados
        }

        private void View_OnEmployeeAdded(Employee newEmployee)
        {
            if (!ValidateDepartmentSelected()) return;
            // Es el repositorio el que se encarga de segregar si es un nuevo empleado o uno existente.
            var result = model.DepartmentSelected!.ControllerEmployee.Save(newEmployee);

            if (result is null)
            {
                MessageBox.Show("No se pudo agregar el empleado " + newEmployee.Name);
            }
            else
            {
                MessageBox.Show("Se agrego el empleado " + newEmployee.Name);
            }

            view.SetDepartmentSelected(model.DepartmentSelected); // Actualizar la lista de empleados
        }

        private void View_OnEmployeeSelected(string employeeDni)
        {
            if (!ValidateDepartmentSelected()) return;

            var employeeRecoverd = model.DepartmentSelected!.ControllerEmployee.FindById(employeeDni);
            if (employeeRecoverd is null)
            {
                MessageBox.Show("No se encontro el empleado");
                return;
            }

            model.EmployeeSelected = employeeRecoverd;
            view.SetEmployeeSelected(employeeRecoverd);
        }

        private void View_OnDepartmentSelected(int departmentId)
        {
            var departmentRecoverd = model.Departments.FindById(departmentId);
            if (departmentRecoverd is null)
            {
                MessageBox.Show("No se encontro el departamento");
                return;
            }

            model.DepartmentSelected = departmentRecoverd;
            view.SetDepartmentSelected(departmentRecoverd);
        }

        private void View_LoadFile(string fileName)
        {
            var oldDepartments = model.Departments.FindAll().ToList(); // ToList para clonar la lista
            model.Departments.DeleteAll();
            model.DepartmentSelected = null;
            try
            {
                string json = File.ReadAllText(fileName);
                var departments = JsonConvert.DeserializeObject<IEnumerable<DepartmentDto>>(json);
                model.Departments.SaveAll(departments.Select(d => d.ToClass(new EmployeeRepositoryMemory())));
                MessageBox.Show("Se ha cargado el archivo exitosamente de " + fileName, "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show("No se pudo cargar el archivo " + fileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                model.Departments.SaveAll(oldDepartments);
            }
            finally
            {
                view.SetDepartmentSelected(model.DepartmentSelected);
                view.SetDepartments(model.Departments.FindAll()); // Actualizar la lista de departamentos
            }
        }

        private void View_SaveFile(string fileName)
        {
            try
            {
                var departments = model.Departments.FindAll().Select(d => d.ToDto());
                string json = JsonConvert.SerializeObject(departments, Formatting.Indented);

                // Create folder if not exists
                var folder = Path.GetDirectoryName(fileName);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                File.WriteAllText(fileName, json);
                MessageBox.Show("Se ha guardado el archivo exitosamente en " + fileName, "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception _)
            {
                MessageBox.Show("No se pudo guardar el archivo " + fileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateDepartmentSelected()
        {
            if (model.DepartmentSelected is null)
            {
                MessageBox.Show("Selecione un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateEmployeeSelected()
        {
            if (model.EmployeeSelected is null)
            {
                MessageBox.Show("Selecione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
