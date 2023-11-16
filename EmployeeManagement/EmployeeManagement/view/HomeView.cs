using EmployeeManagement.models;
using EmployeeManagement.utils;
using System.Diagnostics;

namespace EmployeeManagement.view
{
    public partial class HomeView : Form, IHomeView
    {
        public event CallBackInt OnDepartmentSelected;
        public event CallBackString OnEmployeeSelected;
        public event CallBackEmployee OnEmployeeAdded;
        public event CallBackEmployee OnEmployeeUpdated;
        public event EventHandler OnEmployeeDeleted;
        public event CallBackString LoadFile = delegate { };
        public event CallBackString SaveFile = delegate { };

        public HomeView()
        {
            InitializeComponent();
        }


        #region Setters
        public void SetDepartmentSelected(Department value)
        {
            UpdateEmployeeList(value);
        }

        public void SetEmployeeSelected(Employee value)
        {
            UpdateEmployeeData(value);
        }

        public void SetDepartments(IEnumerable<Department> value)
        {
            UpdateDepartmentList(value);
        }
        #endregion

        #region Update UI
        private void UpdateEmployeeList(Department value)
        {
            listViewEmployees.Items.Clear();
            ClearForm();
            if (value == null) return;
            foreach (var employee in value.ControllerEmployee.FindAll())
            {
                // Dni, Name, Position
                var item = new ListViewItem(employee.Dni);
                item.SubItems.Add(employee.Name);
                item.SubItems.Add(employee.Position);
                item.Tag = employee.Dni;
                listViewEmployees.Items.Add(item);
            }
        }
        private void UpdateDepartmentList(IEnumerable<Department> departments)
        {
            listViewDepartments.Items.Clear();
            foreach (var department in departments)
            {
                var item = new ListViewItem(department.Name);
                item.Tag = department.Id;
                listViewDepartments.Items.Add(item);
            }
        }

        private void UpdateEmployeeData(Employee employee)
        {
            textBoxDni.ReadOnly = true;
            textBoxDni.Text = employee.Dni;
            textBoxName.Text = employee.Name;
            textBoxEmail.Text = employee.Email;
            textBoxPhone.Text = employee.Phone;
            textBoxPosition.Text = employee.Position;
        }

        #endregion

        #region Events
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var employee = GetEmployeeFormData();
            if (employee == null) return;
            OnEmployeeAdded.Invoke(employee);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsEmployeeSelected()) return;
            var employee = GetEmployeeFormData();
            if (employee == null) return;
            OnEmployeeUpdated.Invoke(employee);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!IsEmployeeSelected()) return;
            OnEmployeeDeleted.Invoke(textBoxDni.Text, e);
            ClearForm();
        }

        private void buttonUnselect_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void listViewDepartments_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var department = (int)e.Item.Tag;
                OnDepartmentSelected.Invoke(department);
                ClearForm();
            }
        }

        private void listViewEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var employee = e.Item.Tag as string;
                OnEmployeeSelected.Invoke(employee);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Management v1.0 (Sergio de Iscar)", "Accerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void verAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open https://github.com/SergioDeIscarValera

            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/SergioDeIscarValera",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void rutaPorDefectoCargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var defaultPath = Utils.GetInstance().GetDefaultPath();
            LoadFile.Invoke(defaultPath.Key + defaultPath.Value);
        }

        private void rutaEspecificaCargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                LoadFile.Invoke(ofd.FileName);
                Cursor.Current = Cursors.Default;
            }
        }

        private void rutaPorDefectoGuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var defaultPath = Utils.GetInstance().GetDefaultPath();
            SaveFile.Invoke(defaultPath.Key + defaultPath.Value);
        }

        private void rutaEspecificaGuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON files (*.json)|*.json";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                SaveFile.Invoke(sfd.FileName);
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        private void ClearForm()
        {
            textBoxDni.ReadOnly = false;
            textBoxDni.Text = "";
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            textBoxPosition.Text = "";
        }

        private Employee? GetEmployeeFormData()
        {
            var dni = textBoxDni.Text;
            var name = textBoxName.Text;
            var email = textBoxEmail.Text;
            var phone = textBoxPhone.Text;
            var position = textBoxPosition.Text;

            var utils = Utils.GetInstance();

            if (!utils.ValidateDni(dni.Trim()))
            {
                MessageBox.Show("Dni is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!utils.ValidateStringLength(name.Trim()))
            {
                MessageBox.Show("Name is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!utils.ValidateEmail(email.Trim()))
            {
                MessageBox.Show("Email is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!utils.ValidatePhone(phone.Trim()))
            {
                MessageBox.Show("Phone is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!utils.ValidateStringLength(position.Trim()))
            {
                MessageBox.Show("Position is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return new Employee(dni, name, email, phone, position);
            }

            return null;
        }

        private bool IsEmployeeSelected()
        {
            var dni = textBoxDni.Text;
            if (string.IsNullOrEmpty(dni) || !textBoxDni.ReadOnly)
            {
                MessageBox.Show("Please select an employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
