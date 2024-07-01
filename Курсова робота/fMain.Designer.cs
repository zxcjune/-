namespace Курсова_робота
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lvMain = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassportData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Education = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specialization = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfJoining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastAppointmentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProgrammingLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepartmentManaged = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteEmployee = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveToFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelFilter = new System.Windows.Forms.ToolStripButton();
            this.btnPreparationOfTheOrder = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnShowOlderEmployees = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FullName,
            this.PassportData,
            this.Education,
            this.Specialization,
            this.Department,
            this.Position,
            this.Salary,
            this.DateOfJoining,
            this.LastAppointmentDate,
            this.BirthDate,
            this.Role,
            this.ProgrammingLanguage,
            this.DepartmentManaged});
            this.lvMain.FullRowSelect = true;
            this.lvMain.GridLines = true;
            this.lvMain.HideSelection = false;
            this.lvMain.Location = new System.Drawing.Point(0, 94);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(1482, 353);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvMainColumn_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // FullName
            // 
            this.FullName.Text = "FullName";
            this.FullName.Width = 80;
            // 
            // PassportData
            // 
            this.PassportData.Text = "PassportData";
            this.PassportData.Width = 205;
            // 
            // Education
            // 
            this.Education.Text = "Education";
            this.Education.Width = 70;
            // 
            // Specialization
            // 
            this.Specialization.Text = "Specialization";
            this.Specialization.Width = 70;
            // 
            // Department
            // 
            this.Department.Text = "Department";
            this.Department.Width = 70;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 80;
            // 
            // Salary
            // 
            this.Salary.Text = "Salary";
            // 
            // DateOfJoining
            // 
            this.DateOfJoining.Text = "DateOfJoining";
            this.DateOfJoining.Width = 80;
            // 
            // LastAppointmentDate
            // 
            this.LastAppointmentDate.Text = "LastAppointmentDate";
            this.LastAppointmentDate.Width = 100;
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "BirthDate";
            // 
            // Role
            // 
            this.Role.Text = "Role";
            // 
            // ProgrammingLanguage
            // 
            this.ProgrammingLanguage.Text = "ProgrammingLanguage";
            // 
            // DepartmentManaged
            // 
            this.DepartmentManaged.Text = "DepartmentManaged";
            this.DepartmentManaged.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEmployee,
            this.btnEdit,
            this.btnDeleteEmployee,
            this.btnOpenFromFile,
            this.btnSaveToFile,
            this.toolStripButton1,
            this.btnCancelFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1465, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(29, 24);
            this.btnAddEmployee.Text = "Додати нового робітника";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 24);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(29, 24);
            this.btnDeleteEmployee.Text = "Видалити робітника";
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnOpenFromFile
            // 
            this.btnOpenFromFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFromFile.Image")));
            this.btnOpenFromFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFromFile.Name = "btnOpenFromFile";
            this.btnOpenFromFile.Size = new System.Drawing.Size(29, 24);
            this.btnOpenFromFile.Text = "Відкрити з файлу";
            this.btnOpenFromFile.Click += new System.EventHandler(this.btnOpenFromFile_click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveToFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToFile.Image")));
            this.btnSaveToFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(29, 24);
            this.btnSaveToFile.Text = "Зберегти у файл";
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelFilter.Image")));
            this.btnCancelFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(29, 24);
            this.btnCancelFilter.Text = "btnCancelFilter";
            this.btnCancelFilter.ToolTipText = "Відмінити фільтрування";
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // btnPreparationOfTheOrder
            // 
            this.btnPreparationOfTheOrder.Location = new System.Drawing.Point(12, 30);
            this.btnPreparationOfTheOrder.Name = "btnPreparationOfTheOrder";
            this.btnPreparationOfTheOrder.Size = new System.Drawing.Size(106, 58);
            this.btnPreparationOfTheOrder.TabIndex = 2;
            this.btnPreparationOfTheOrder.Text = "Підготовка наказу";
            this.btnPreparationOfTheOrder.UseVisualStyleBackColor = true;
            this.btnPreparationOfTheOrder.Click += new System.EventHandler(this.btnPreparationOfTheOrder_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(15, 30);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 22);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Location = new System.Drawing.Point(124, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // btnShowOlderEmployees
            // 
            this.btnShowOlderEmployees.Location = new System.Drawing.Point(275, 30);
            this.btnShowOlderEmployees.Name = "btnShowOlderEmployees";
            this.btnShowOlderEmployees.Size = new System.Drawing.Size(107, 58);
            this.btnShowOlderEmployees.TabIndex = 5;
            this.btnShowOlderEmployees.Text = "Показати старших за 55";
            this.btnShowOlderEmployees.UseVisualStyleBackColor = true;
            this.btnShowOlderEmployees.Click += new System.EventHandler(this.btnShowOlderEmployees_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 450);
            this.Controls.Add(this.btnShowOlderEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPreparationOfTheOrder);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvMain);
            this.Name = "fMain";
            this.Text = "Відділ кадрів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddEmployee;
        private System.Windows.Forms.ToolStripButton btnDeleteEmployee;
        private System.Windows.Forms.ToolStripButton btnSaveToFile;
        private System.Windows.Forms.ToolStripButton btnOpenFromFile;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader PassportData;
        private System.Windows.Forms.ColumnHeader Education;
        private System.Windows.Forms.ColumnHeader Specialization;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader DateOfJoining;
        private System.Windows.Forms.ColumnHeader LastAppointmentDate;
        private System.Windows.Forms.ColumnHeader BirthDate;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.ColumnHeader ProgrammingLanguage;
        private System.Windows.Forms.ColumnHeader DepartmentManaged;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.Button btnPreparationOfTheOrder;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnShowOlderEmployees;
        private System.Windows.Forms.ToolStripButton btnCancelFilter;
    }
}

