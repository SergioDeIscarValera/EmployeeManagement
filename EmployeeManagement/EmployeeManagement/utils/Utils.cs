using EmployeeManagement.models;
using EmployeeManagement.Properties;
using EmployeeManagement.repositories.employee;
using System.Text.RegularExpressions;

namespace EmployeeManagement.utils;

internal class Utils
{
    private Utils() { }

    private static Utils instance;

    private static Regex regexDni = new Regex(@"^[0-9]{8}[a-z]$", RegexOptions.IgnoreCase);
    private static Regex regexEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.IgnoreCase);
    private static Regex regexPhone = new Regex(@"^[0-9]{9}$", RegexOptions.IgnoreCase);

    public static Utils GetInstance()
    {
        if (instance == null)
        {
            instance = new Utils();
        }
        return instance;
    }

    /// <summary>
    /// Ruta por defecto para guardar y cargar los datos + nombre del archivo formateado
    /// </summary>
    /// <returns> Path por defecto, ruta relativa del archivo json</returns>
    public KeyValuePair<string, string> GetDefaultPath()
    {
        string filepath = Settings.Default.file_path_default.Replace('-', Path.DirectorySeparatorChar);
        string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        return new KeyValuePair<string, string>(defaultPath, filepath);
    }

    internal IEnumerable<Department> GetDefaultDepartments()
    {
        MessageBox.Show("Loading example data", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information);
        var departments = new List<Department>
        {
            new Department("IT", new EmployeeRepositoryMemory()),
            new Department("RRHH", new EmployeeRepositoryMemory()),
            new Department("Ventas", new EmployeeRepositoryMemory()),
        };

        for (var i = 0; i < departments.Count; i++)
        {
            for (var j = 0; j < 10; j++)
            {
                departments[i].ControllerEmployee.Save(
                    new Employee(
                        dni: $"{i}{j}138400S",
                        name: $"Employee {(i + 1) * j}",
                        email: $"employee{(i + 1) * j}@email.com",
                        phone: $"6447317{i}{j}",
                        position: "su propio jefe :D"
                    )
                );
            }
        }

        return departments;
    }

    public bool ValidateDni(string dni)
    {
        return regexDni.IsMatch(dni);     
    }

    public bool ValidateStringLength(string text, int minLength = 2, int maxLength = 30)
    {
        return text.Length >= minLength && text.Length <= maxLength;
    }

    public bool ValidateEmail(string email)
    {
        return regexEmail.IsMatch(email);
    }

    internal bool ValidatePhone(string phone)
    {
        return regexPhone.IsMatch(phone);
    }
}
