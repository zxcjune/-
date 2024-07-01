using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLib;
using PassportDataLib;

namespace DeveloperLib
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(int id, string fullName, PassportData passport, string education, string specialization, string department, string position,  DateTime dateOfJoining, DateTime lastAppointmentDate, DateTime birthDate, string role, string programmingLanguage)
            : base(id, fullName, passport, education, specialization, department, position,  dateOfJoining, lastAppointmentDate, birthDate, role)
        {
            Salary = CalculateAnnualSalary();
            ProgrammingLanguage = programmingLanguage;
        }

        public override double CalculateAnnualSalary()
        {
            return 1000 * 12;
        }
    }
}
