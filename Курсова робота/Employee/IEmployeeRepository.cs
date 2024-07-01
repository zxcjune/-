using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace IEmployeeLib
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        void RemoveEmployee(int id);
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        int CalculateAge(DateTime birthDate);
        void LoadEmployees(List<Employee> employees);
        void UpdateEmployee(Employee employee);
        List<Employee> SelectEmployeesForRetirement();
        void ExportRetirementOrderToPdf(List<Employee> employeesToRetire, string filePath);
    }
}
