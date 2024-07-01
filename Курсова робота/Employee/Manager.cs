using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;
using PassportDataLib;

namespace ManagerLib
{
    public class Manager : Employee
    {
        public string DepartmentManaged { get; set; }

        public Manager(int id, string fullName, PassportData passport, string education, string specialization, string department, string position,  DateTime dateOfJoining, DateTime lastAppointmentDate, DateTime birthDate,string role, string departmentManaged)
        : base(id, fullName, passport, education, specialization, department, position, dateOfJoining, lastAppointmentDate, birthDate, role)
        {
            Salary = CalculateAnnualSalary();
            DepartmentManaged = departmentManaged;
        }

        public override double CalculateAnnualSalary()
        {
            return 1000 * 16;
        }
    }
}