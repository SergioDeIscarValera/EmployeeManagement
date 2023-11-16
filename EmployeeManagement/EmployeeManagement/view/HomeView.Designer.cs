namespace EmployeeManagement.view
{
    partial class HomeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonUnselect = new Button();
            splitContainer1 = new SplitContainer();
            listViewDepartments = new ListView();
            columnDName = new ColumnHeader();
            listViewEmployees = new ListView();
            columnEDni = new ColumnHeader();
            columnEName = new ColumnHeader();
            columnEPosition = new ColumnHeader();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxDni = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxPosition = new TextBox();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cargarToolStripMenuItem = new ToolStripMenuItem();
            rutaPorDefectoCargarToolStripMenuItem = new ToolStripMenuItem();
            rutaEspecificaCargarToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            rutaPorDefectoGuardarToolStripMenuItem = new ToolStripMenuItem();
            rutaEspecificaGuardarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            verAyudaToolStripMenuItem = new ToolStripMenuItem();
            archToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(248, 249, 250);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.1F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.9F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.92527F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.074733F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1000, 534);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0654221F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.9345779F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel2.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonUpdate, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonDelete, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonUnselect, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(584, 488);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(413, 43);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(86, 204, 157);
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.ForeColor = Color.FromArgb(248, 249, 250);
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(98, 37);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(108, 195, 213);
            buttonUpdate.Dock = DockStyle.Fill;
            buttonUpdate.ForeColor = Color.FromArgb(248, 249, 250);
            buttonUpdate.Location = new Point(107, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(101, 37);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 120, 81);
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.ForeColor = Color.FromArgb(248, 249, 250);
            buttonDelete.Location = new Point(214, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(93, 37);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Remove";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUnselect
            // 
            buttonUnselect.BackColor = Color.FromArgb(52, 58, 64);
            buttonUnselect.Dock = DockStyle.Fill;
            buttonUnselect.ForeColor = Color.FromArgb(248, 249, 250);
            buttonUnselect.Location = new Point(313, 3);
            buttonUnselect.Name = "buttonUnselect";
            buttonUnselect.Size = new Size(97, 37);
            buttonUnselect.TabIndex = 3;
            buttonUnselect.Text = "Clear";
            buttonUnselect.UseVisualStyleBackColor = false;
            buttonUnselect.Click += buttonUnselect_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listViewDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listViewEmployees);
            splitContainer1.Size = new Size(575, 479);
            splitContainer1.SplitterDistance = 197;
            splitContainer1.TabIndex = 1;
            // 
            // listViewDepartments
            // 
            listViewDepartments.BackColor = Color.FromArgb(243, 150, 154);
            listViewDepartments.Columns.AddRange(new ColumnHeader[] { columnDName });
            listViewDepartments.Dock = DockStyle.Fill;
            listViewDepartments.ForeColor = Color.FromArgb(248, 249, 250);
            listViewDepartments.Location = new Point(0, 0);
            listViewDepartments.MultiSelect = false;
            listViewDepartments.Name = "listViewDepartments";
            listViewDepartments.Size = new Size(197, 479);
            listViewDepartments.TabIndex = 0;
            listViewDepartments.UseCompatibleStateImageBehavior = false;
            listViewDepartments.View = View.Details;
            listViewDepartments.ItemSelectionChanged += listViewDepartments_ItemSelectionChanged;
            // 
            // columnDName
            // 
            columnDName.Text = "Name";
            columnDName.Width = 180;
            // 
            // listViewEmployees
            // 
            listViewEmployees.BackColor = Color.FromArgb(108, 195, 213);
            listViewEmployees.Columns.AddRange(new ColumnHeader[] { columnEDni, columnEName, columnEPosition });
            listViewEmployees.Dock = DockStyle.Fill;
            listViewEmployees.ForeColor = Color.FromArgb(248, 249, 250);
            listViewEmployees.Location = new Point(0, 0);
            listViewEmployees.MultiSelect = false;
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(374, 479);
            listViewEmployees.TabIndex = 0;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            listViewEmployees.View = View.Details;
            listViewEmployees.ItemSelectionChanged += listViewEmployees_ItemSelectionChanged;
            // 
            // columnEDni
            // 
            columnEDni.Text = "DNI";
            columnEDni.Width = 100;
            // 
            // columnEName
            // 
            columnEName.Text = "NAME";
            columnEName.TextAlign = HorizontalAlignment.Center;
            columnEName.Width = 100;
            // 
            // columnEPosition
            // 
            columnEPosition.Text = "POSITION";
            columnEPosition.TextAlign = HorizontalAlignment.Center;
            columnEPosition.Width = 150;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.66586F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.33414F));
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 3);
            tableLayoutPanel3.Controls.Add(label4, 0, 4);
            tableLayoutPanel3.Controls.Add(label5, 0, 5);
            tableLayoutPanel3.Controls.Add(textBoxDni, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxName, 1, 2);
            tableLayoutPanel3.Controls.Add(textBoxEmail, 1, 3);
            tableLayoutPanel3.Controls.Add(textBoxPhone, 1, 4);
            tableLayoutPanel3.Controls.Add(textBoxPosition, 1, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(584, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 47.42268F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 52.57732F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(413, 479);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(120, 194, 173);
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(100, 82);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.FromArgb(243, 150, 154);
            label2.Location = new Point(3, 131);
            label2.Name = "label2";
            label2.Size = new Size(100, 91);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.ForeColor = Color.FromArgb(86, 204, 157);
            label3.Location = new Point(3, 222);
            label3.Name = "label3";
            label3.Size = new Size(100, 84);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.ForeColor = Color.FromArgb(108, 195, 213);
            label4.Location = new Point(3, 306);
            label4.Name = "label4";
            label4.Size = new Size(100, 86);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.ForeColor = Color.FromArgb(255, 120, 81);
            label5.Location = new Point(3, 392);
            label5.Name = "label5";
            label5.Size = new Size(100, 87);
            label5.TabIndex = 4;
            label5.Text = "Position:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = Color.FromArgb(248, 249, 250);
            textBoxDni.ForeColor = Color.FromArgb(120, 194, 173);
            textBoxDni.Location = new Point(109, 49);
            textBoxDni.Margin = new Padding(3, 0, 15, 3);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(289, 27);
            textBoxDni.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BackColor = Color.FromArgb(248, 249, 250);
            textBoxName.ForeColor = Color.FromArgb(243, 150, 154);
            textBoxName.Location = new Point(109, 131);
            textBoxName.Margin = new Padding(3, 0, 15, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(289, 27);
            textBoxName.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.BackColor = Color.FromArgb(248, 249, 250);
            textBoxEmail.ForeColor = Color.FromArgb(86, 204, 157);
            textBoxEmail.Location = new Point(109, 222);
            textBoxEmail.Margin = new Padding(3, 0, 15, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(289, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhone.BackColor = Color.FromArgb(248, 249, 250);
            textBoxPhone.ForeColor = Color.FromArgb(108, 195, 213);
            textBoxPhone.Location = new Point(109, 306);
            textBoxPhone.Margin = new Padding(3, 0, 15, 3);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(289, 27);
            textBoxPhone.TabIndex = 8;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPosition.BackColor = Color.FromArgb(248, 249, 250);
            textBoxPosition.ForeColor = Color.FromArgb(255, 120, 81);
            textBoxPosition.Location = new Point(109, 392);
            textBoxPosition.Margin = new Padding(3, 0, 15, 3);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(289, 27);
            textBoxPosition.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(52, 58, 64);
            label6.Location = new Point(3, 485);
            label6.Margin = new Padding(3, 0, 3, 3);
            label6.Name = "label6";
            label6.Size = new Size(207, 46);
            label6.TabIndex = 3;
            label6.Text = "Realizado por: Sergio de Iscar";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(120, 194, 173);
            menuStrip1.ForeColor = Color.FromArgb(248, 249, 250);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.BackColor = Color.FromArgb(120, 194, 173);
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarToolStripMenuItem, guardarToolStripMenuItem });
            archivoToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            cargarToolStripMenuItem.BackColor = Color.FromArgb(243, 150, 154);
            cargarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rutaPorDefectoCargarToolStripMenuItem, rutaEspecificaCargarToolStripMenuItem });
            cargarToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            cargarToolStripMenuItem.Size = new Size(145, 26);
            cargarToolStripMenuItem.Text = "Cargar";
            // 
            // rutaPorDefectoCargarToolStripMenuItem
            // 
            rutaPorDefectoCargarToolStripMenuItem.BackColor = Color.FromArgb(243, 150, 154);
            rutaPorDefectoCargarToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            rutaPorDefectoCargarToolStripMenuItem.Name = "rutaPorDefectoCargarToolStripMenuItem";
            rutaPorDefectoCargarToolStripMenuItem.Size = new Size(204, 26);
            rutaPorDefectoCargarToolStripMenuItem.Text = "Ruta por defecto";
            rutaPorDefectoCargarToolStripMenuItem.Click += rutaPorDefectoCargarToolStripMenuItem_Click;
            // 
            // rutaEspecificaCargarToolStripMenuItem
            // 
            rutaEspecificaCargarToolStripMenuItem.BackColor = Color.FromArgb(243, 150, 154);
            rutaEspecificaCargarToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            rutaEspecificaCargarToolStripMenuItem.Name = "rutaEspecificaCargarToolStripMenuItem";
            rutaEspecificaCargarToolStripMenuItem.Size = new Size(204, 26);
            rutaEspecificaCargarToolStripMenuItem.Text = "Ruta especifica";
            rutaEspecificaCargarToolStripMenuItem.Click += rutaEspecificaCargarToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.BackColor = Color.FromArgb(86, 204, 157);
            guardarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rutaPorDefectoGuardarToolStripMenuItem, rutaEspecificaGuardarToolStripMenuItem });
            guardarToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(145, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // rutaPorDefectoGuardarToolStripMenuItem
            // 
            rutaPorDefectoGuardarToolStripMenuItem.BackColor = Color.FromArgb(86, 204, 157);
            rutaPorDefectoGuardarToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            rutaPorDefectoGuardarToolStripMenuItem.Name = "rutaPorDefectoGuardarToolStripMenuItem";
            rutaPorDefectoGuardarToolStripMenuItem.Size = new Size(204, 26);
            rutaPorDefectoGuardarToolStripMenuItem.Text = "Ruta por defecto";
            rutaPorDefectoGuardarToolStripMenuItem.Click += rutaPorDefectoGuardarToolStripMenuItem_Click;
            // 
            // rutaEspecificaGuardarToolStripMenuItem
            // 
            rutaEspecificaGuardarToolStripMenuItem.BackColor = Color.FromArgb(86, 204, 157);
            rutaEspecificaGuardarToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            rutaEspecificaGuardarToolStripMenuItem.Name = "rutaEspecificaGuardarToolStripMenuItem";
            rutaEspecificaGuardarToolStripMenuItem.Size = new Size(204, 26);
            rutaEspecificaGuardarToolStripMenuItem.Text = "Ruta especifica";
            rutaEspecificaGuardarToolStripMenuItem.Click += rutaEspecificaGuardarToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.BackColor = Color.FromArgb(120, 194, 173);
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, verAyudaToolStripMenuItem });
            ayudaToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.BackColor = Color.FromArgb(108, 195, 213);
            acercaDeToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(158, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // verAyudaToolStripMenuItem
            // 
            verAyudaToolStripMenuItem.BackColor = Color.FromArgb(255, 206, 103);
            verAyudaToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            verAyudaToolStripMenuItem.Size = new Size(158, 26);
            verAyudaToolStripMenuItem.Text = "Ver ayuda";
            verAyudaToolStripMenuItem.Click += verAyudaToolStripMenuItem_Click;
            // 
            // archToolStripMenuItem
            // 
            archToolStripMenuItem.BackColor = Color.FromArgb(120, 194, 173);
            archToolStripMenuItem.ForeColor = Color.FromArgb(248, 249, 250);
            archToolStripMenuItem.Name = "archToolStripMenuItem";
            archToolStripMenuItem.Size = new Size(32, 19);
            archToolStripMenuItem.Text = "Arch";
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomeView";
            Text = "Employee Management";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private SplitContainer splitContainer1;
        private ListView listViewDepartments;
        private ListView listViewEmployees;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxDni;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxPosition;
        private Button buttonUnselect;
        private ColumnHeader columnDName;
        private ColumnHeader columnEDni;
        private ColumnHeader columnEName;
        private ColumnHeader columnEPosition;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cargarToolStripMenuItem;
        private ToolStripMenuItem rutaPorDefectoCargarToolStripMenuItem;
        private ToolStripMenuItem rutaEspecificaCargarToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem rutaPorDefectoGuardarToolStripMenuItem;
        private ToolStripMenuItem rutaEspecificaGuardarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem verAyudaToolStripMenuItem;

        private Color primary;
        private Color secondary;
        private Color success;
        private Color info;
        private Color warning;
        private Color danger;
        private Color light;
        private Color dark;
    }
}