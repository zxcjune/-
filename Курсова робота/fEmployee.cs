using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeveloperLib;
using EmployeeLib;
using ManagerLib;
using PassportDataLib;

namespace Курсова_робота
{
    public partial class fEmployee : Form
    {
        public Employee newEmployee { get; private set; }
        public fEmployee()
        {
            InitializeComponent();
        }

        public fEmployee(Employee selectedEmployee) : this()
        {
            FillFormWithEmployeeData(selectedEmployee);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string fullName = tbFullName.Text;
            string passportNumber = tbPassportSeriesAndNumber.Text;
            string issuingAuthority = tbPassportIssuingAuthority.Text;
            DateTime issueDate;
            DateTime expiryDate;
            string education = tbEducation.Text;
            string specialization = tbSpecialization.Text;
            string department = tbDepartment.Text;
            string position = tbPosition.Text;
            DateTime dateOfJoining;
            DateTime lastAppointmentDate;
            DateTime birthDate;
            string placeOfBirth = tbPassportPlaceOfBirth.Text;

            if (!DateTime.TryParse(tbPassportIssueDate.Text, out issueDate) ||
            !DateTime.TryParse(tbDateOfJoining.Text, out dateOfJoining) ||
            !DateTime.TryParse(tbLastAppointmentDate.Text, out lastAppointmentDate) ||
            !DateTime.TryParse(tbBirthDate.Text, out birthDate)||
            !DateTime.TryParse(tbExpiryDate.Text, out expiryDate))
            {
                MessageBox.Show("Введіть вірну дату в форматі dd/MM/yyyy.", "Неправильна дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = cmbRole.SelectedItem.ToString();
            if (role == null)
                return;
            switch (role)
            {
                case "Менеджер":
                    string departmentManaged = tbDepartmentManaged.Text;
                    newEmployee = new Manager(0, fullName, new PassportData(passportNumber, issueDate, issuingAuthority, placeOfBirth, expiryDate), education, specialization, department, position, dateOfJoining, lastAppointmentDate, birthDate, role, departmentManaged);
                    break;
                case "Розробник":
                    string programmingLanguage = tbProgrammingLanguage.Text;
                    newEmployee = new Developer(0, fullName, new PassportData(passportNumber, issueDate, issuingAuthority, placeOfBirth, expiryDate), education, specialization, department, position, dateOfJoining, lastAppointmentDate, birthDate, role,  programmingLanguage);
                    break;
                case "Робітник":
                    newEmployee = new Employee(0, fullName, new PassportData(passportNumber, issueDate, issuingAuthority, placeOfBirth, expiryDate), education, specialization, department, position,  dateOfJoining, lastAppointmentDate, birthDate, role);
                    break;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FillFormWithEmployeeData(Employee employee)
        {
            tbFullName.Text = employee.FullName;
            tbPassportSeriesAndNumber.Text = employee.Passport.SeriesAndNumber;
            tbPassportIssuingAuthority.Text = employee.Passport.IssuingAuthority;
            tbPassportIssueDate.Text = employee.Passport.IssueDate.ToString("dd/MM/yyyy");
            tbExpiryDate.Text = employee.Passport.ExpiryDate.ToString("dd/MM/yyyy");
            tbEducation.Text = employee.Education;
            tbSpecialization.Text = employee.Specialization;
            tbDepartment.Text = employee.Department;
            tbPosition.Text = employee.Position;
            tbDateOfJoining.Text = employee.DateOfJoining.ToString("dd/MM/yyyy");
            tbLastAppointmentDate.Text = employee.LastAppointmentDate.ToString("dd/MM/yyyy");
            tbBirthDate.Text = employee.BirthDate.ToString("dd/MM/yyyy");
            tbPassportPlaceOfBirth.Text = employee.Passport.PlaceOfBirth;
            cmbRole.SelectedItem = employee is Manager ? "Менеджер" : employee is Developer ? "Розробник" : "Робітник";

            if (employee is Developer developer)
            {
                tbProgrammingLanguage.Text = developer.ProgrammingLanguage;
            }
            else if (employee is Manager manager)
            {
                tbDepartmentManaged.Text = manager.DepartmentManaged;
            }

            cmbRole_SelectedIndexChanged(null, null);
        }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbRole.SelectedItem.ToString();

            tbDepartmentManaged.Visible = false;
            tbProgrammingLanguage.Visible = false;
            lbDepartmentManaged.Visible = false;
            lbProgrammingLanguage.Visible = false;

            if (selectedRole == "Менеджер")
            {
                tbDepartmentManaged.Visible = true;
                lbDepartmentManaged.Visible = true;
            }
            else if (selectedRole == "Розробник")
            {
                tbProgrammingLanguage.Visible = true;
                lbProgrammingLanguage.Visible = true;
            }
        }
    }

}

