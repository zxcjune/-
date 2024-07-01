using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassportDataLib;
using ManagerLib;
using DeveloperLib;

namespace EmployeeLib
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public PassportData Passport { get; set; }
        public string Education { get; set; }
        public string Specialization { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime LastAppointmentDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; }


        public virtual double CalculateAnnualSalary()
        {
            return 1000 * 10;
        }

        public Employee()
        {
            Salary = CalculateAnnualSalary();
        }

        public Employee(int id, string fullName) : this(id, fullName, null, string.Empty, string.Empty, string.Empty, string.Empty, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, string.Empty)
        {
            Salary = CalculateAnnualSalary();
        }

        public Employee(int id, string fullName, PassportData passport, string education, string specialization, string department, string position, DateTime dateOfJoining, DateTime lastAppointmentDate, DateTime birthDate, string role)
        {
            Id = id;
            FullName = fullName;
            Passport = passport;
            Education = education;
            Specialization = specialization;
            Department = department;
            Position = position;
            Salary = CalculateAnnualSalary();
            DateOfJoining = dateOfJoining;
            LastAppointmentDate = lastAppointmentDate;
            BirthDate = birthDate;
            Role = role;
        }
    }
}
