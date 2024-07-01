using IEmployeeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveDataLib;
using DeveloperLib;
using ManagerLib;
using EmployeeLib;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Курсова_робота.ColumnSorter;

namespace Курсова_робота
{
    public partial class fMain : Form
    {
        private IEmployeeRepository employeeRepository;
        private const string DefaultFilePath = "employees.json";
        private List<ListViewItem> originalItems;
        public fMain()
        {
            InitializeComponent();
            lvMain.ListViewItemSorter = new ListViewColumnSorter();
            employeeRepository = new EmployeeRepository();
            LoadEmployeesFromFile(DefaultFilePath);
            SaveOriginalItems();
        }

        private void LoadEmployees()
        {
            lvMain.Items.Clear();
            var employees = employeeRepository.GetAllEmployees();
            foreach (var employee in employees)
            {
                var item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.FullName);
                item.SubItems.Add(employee.Passport.ToString());
                item.SubItems.Add(employee.Education);
                item.SubItems.Add(employee.Specialization);
                item.SubItems.Add(employee.Department);
                item.SubItems.Add(employee.Position);
                item.SubItems.Add(employee.Salary.ToString("F2"));
                item.SubItems.Add(employee.DateOfJoining.ToString("d"));
                item.SubItems.Add(employee.LastAppointmentDate.ToString("d"));
                item.SubItems.Add(employee.BirthDate.ToString("d"));
                item.SubItems.Add(employee.Role);

                if (employee is Developer developer)
                {
                    item.SubItems.Add(developer.ProgrammingLanguage.ToString());
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                }

                if (employee is Manager manager)
                {
                    item.SubItems.Add(manager.DepartmentManaged.ToString());
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                }
                lvMain.Items.Add(item);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var fEmployee = new fEmployee();
            if(fEmployee.ShowDialog() == DialogResult.OK)
            {
                var newEmployee = fEmployee.newEmployee;
                newEmployee.Salary = newEmployee.CalculateAnnualSalary();
                employeeRepository.AddEmployee(newEmployee);
                LoadEmployees();
            }
        }

        private void UpdateListViewItem(ListViewItem item, Employee employee)
        {
            
                item.SubItems[1].Text = employee.FullName;
                item.SubItems[2].Text = employee.Passport.ToString();
                item.SubItems[3].Text = employee.Education;
                item.SubItems[4].Text = employee.Specialization;
                item.SubItems[5].Text = employee.Department;
                item.SubItems[6].Text = employee.Position;
                item.SubItems[7].Text = employee.Salary.ToString("F2");
                item.SubItems[8].Text = employee.DateOfJoining.ToString("d");
                item.SubItems[9].Text = employee.LastAppointmentDate.ToString("d");
                item.SubItems[10].Text = employee.BirthDate.ToString("d");
                item.SubItems[11].Text = employee.Role;

                item.SubItems[12].Text = string.Empty;
                item.SubItems[13].Text = string.Empty;

            if (employee is Manager manager)
                {
                    item.SubItems[13].Text = manager.DepartmentManaged;
                }
                else if (employee is Developer developer)
                {
                    item.SubItems[12].Text = developer.ProgrammingLanguage;
                }

        }



        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployeesToFile(DefaultFilePath);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count > 0)
            {
                var selectedItem = lvMain.SelectedItems[0];
                int id = int.Parse(selectedItem.SubItems[0].Text);

                employeeRepository.RemoveEmployee(id);

                LoadEmployees();
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = "json",
                AddExtension = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                SaveEmployeesToFile(saveFileDialog.FileName);
        }

        private void btnOpenFromFile_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = "json",
                AddExtension = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                LoadEmployeesFromFile(openFileDialog.FileName);
        }

        private void LoadEmployeesFromFile(string filePath)
        {
            var employees = SaveData.LoadEmployeesFromFile(filePath);
            employeeRepository.LoadEmployees(employees);
            LoadEmployees();
        }

        private void SaveEmployeesToFile(string filePath)
        {
            var employees = employeeRepository.GetAllEmployees();
            SaveData.SaveEmployeesToFile(employees, filePath);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                if (lvMain.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Будь ласка, виберіть працівника для редагування.", "Редагування працівника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int employeeId = int.Parse(lvMain.SelectedItems[0].SubItems[0].Text);
                Employee selectedEmployee = employeeRepository.GetEmployee(employeeId);
                if (selectedEmployee == null)
                {
                    MessageBox.Show("Робітник не знайдений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (fEmployee form = new fEmployee(selectedEmployee))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Employee editedEmployee = form.newEmployee;
                        editedEmployee.Id = employeeId;
                        editedEmployee.Salary = editedEmployee.CalculateAnnualSalary();
                        employeeRepository.UpdateEmployee(editedEmployee);
                        UpdateListViewItem(lvMain.SelectedItems[0], editedEmployee);
                    }
                }
        }

        private void btnPreparationOfTheOrder_Click(object sender, EventArgs e)
        {
            List<Employee> selectedEmployees = new List<Employee>();

            foreach (ListViewItem item in lvMain.SelectedItems)
            {
                int index = item.Index;
                int employeeId = int.Parse(item.SubItems[0].Text);
                Employee employee = employeeRepository.GetEmployee(employeeId);
                if (employee != null)
                {
                    selectedEmployees.Add(employee);
                }
            }

            if (selectedEmployees.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Retirement Order PDF";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        employeeRepository.ExportRetirementOrderToPdf(selectedEmployees, saveFileDialog.FileName);
                        MessageBox.Show("PDF has been successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select at least one employee.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void lvMainColumn_Click(object sender, ColumnClickEventArgs e)
        {
            if (lvMain.Sorting == SortOrder.Ascending)
                lvMain.Sorting = SortOrder.Descending;
            else
                lvMain.Sorting = SortOrder.Ascending;

            ((ListViewColumnSorter)lvMain.ListViewItemSorter).ColumnIndex = e.Column;
            ((ListViewColumnSorter)lvMain.ListViewItemSorter).SortOrder = lvMain.Sorting;

            lvMain.Sort();
        }



        private void SaveOriginalItems()
        {
            originalItems = lvMain.Items.Cast<ListViewItem>().ToList();
        }

        private void RestoreOriginalItems()
        {
            lvMain.Items.Clear();
            lvMain.Items.AddRange(originalItems.ToArray());
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                RestoreOriginalItems();
                return;
            }

            List<ListViewItem> itemsToRemove = new List<ListViewItem>();

            foreach (ListViewItem item in lvMain.Items)
            {
                bool found = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (ListViewItem item in itemsToRemove)
            {
                lvMain.Items.Remove(item);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            RestoreOriginalItems();
        }

        private void btnShowOlderEmployees_Click(object sender, EventArgs e)
        {
                DateTime currentDate = DateTime.Now;

                DateTime ageLimitDate = currentDate.AddYears(-55);

                var olderEmployees = employeeRepository.GetAllEmployees()
                                                       .Where(emp => emp.BirthDate <= ageLimitDate)
                                                       .ToList();

                lvMain.Items.Clear();

                foreach (var employee in olderEmployees)
                {
                    var item = new ListViewItem(employee.Id.ToString());
                    item.SubItems.Add(employee.FullName);
                    item.SubItems.Add(employee.Passport.ToString());
                    item.SubItems.Add(employee.Education);
                    item.SubItems.Add(employee.Specialization);
                    item.SubItems.Add(employee.Department);
                    item.SubItems.Add(employee.Position);
                    item.SubItems.Add(employee.Salary.ToString("F2"));
                    item.SubItems.Add(employee.DateOfJoining.ToString("d"));
                    item.SubItems.Add(employee.LastAppointmentDate.ToString("d"));
                    item.SubItems.Add(employee.BirthDate.ToString("d"));
                    item.SubItems.Add(employee.Role);

                    if (employee is Developer developer)
                    {
                        item.SubItems.Add(developer.ProgrammingLanguage);
                    }
                    else
                    {
                        item.SubItems.Add(string.Empty);
                    }

                    if (employee is Manager manager)
                    {
                        item.SubItems.Add(manager.DepartmentManaged);
                    }
                    else
                    {
                        item.SubItems.Add(string.Empty);
                    }
                    lvMain.Items.Add(item);
                }

                if (olderEmployees.Count == 0)
                {
                    MessageBox.Show("No employees found over the age of 55.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}
