using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEmployeeLib;
using EmployeeLib;
using PassportDataLib;
using ManagerLib;
using DeveloperLib;
using System.Runtime.Remoting.Contexts;
using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Drawing;
using System.Xml.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;


namespace Курсова_робота
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employee.Id = employees.Count > 0 ? employees.Max(e => e.Id) + 1 : 1;
            employees.Add(employee);
        }

        public void RemoveEmployee(int id)
        {
            var employee = GetEmployee(id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }

        public Employee GetEmployee(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public void LoadEmployees(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            if (existingEmployee != null)
            {
                employees.Remove(existingEmployee);

                Employee updatedEmployee;
                if (employee is Manager)
                {
                    updatedEmployee = new Manager(employee.Id, employee.FullName, employee.Passport, employee.Education, employee.Specialization, employee.Department, employee.Position,  employee.DateOfJoining, employee.LastAppointmentDate, employee.BirthDate, employee.Role, ((Manager)employee).DepartmentManaged);
                }
                else if (employee is Developer)
                {
                    updatedEmployee = new Developer(employee.Id, employee.FullName, employee.Passport, employee.Education, employee.Specialization, employee.Department, employee.Position,employee.DateOfJoining, employee.LastAppointmentDate, employee.BirthDate, employee.Role, ((Developer)employee).ProgrammingLanguage);
                }
                else
                {
                    updatedEmployee = new Employee(employee.Id, employee.FullName, employee.Passport, employee.Education, employee.Specialization, employee.Department, employee.Position, employee.DateOfJoining, employee.LastAppointmentDate, employee.BirthDate, employee.Role);
                }

                employees.Add(updatedEmployee);
            }
        }
        public int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age--;
            return age;
        }

        public List<Employee> SelectEmployeesForRetirement()
        {
            int preRetirementAge = 55;

            var selectedEmployees = employees.Where(e =>
            {
                int age = CalculateAge(e.BirthDate);
                return age >= preRetirementAge;
            }).ToList();

            return selectedEmployees;
        }

        public void ExportRetirementOrderToPdf(List<Employee> employeesToRetire, string filePath)
        {
            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont titleFont = new XFont("Arial", 16);
            XFont regularFont = new XFont("Arial", 12);

            gfx.DrawString("Наказ про звільнення співробітників", titleFont, XBrushes.Black,
                new XRect(0, 20, page.Width.Point, page.Height.Point),
                XStringFormats.TopCenter);

            int yOffset = 100;
            foreach (var employee in employeesToRetire)
            {
                yOffset += 20;

                gfx.DrawString($"Ім'я: {employee.FullName}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Паспортні дані: {employee.Passport.SeriesAndNumber}, " +
                               $"{employee.Passport.IssuingAuthority}, " +
                               $"{employee.Passport.IssueDate.ToShortDateString()}, " +
                               $"{employee.Passport.ExpiryDate.ToShortDateString()}, " +
                $"{employee.Passport.PlaceOfBirth}",
                regularFont, XBrushes.Black,
                               new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                               XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Освіта: {employee.Education}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Спеціальність: {employee.Specialization}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Підрозділ: {employee.Department}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Посада: {employee.Position}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Оклад: {employee.Salary}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Дата надходження у фірму: {employee.DateOfJoining.ToShortDateString()}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Дата останнього призначення: {employee.LastAppointmentDate.ToShortDateString()}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Дата народження: {employee.BirthDate.ToShortDateString()}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                gfx.DrawString($"Роль: {employee.Role}", regularFont, XBrushes.Black,
                    new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                    XStringFormats.TopLeft);

                yOffset += 20;

                if (employee is Manager manager)
                {
                    gfx.DrawString($"Керований підрозділ: {manager.DepartmentManaged}", regularFont, XBrushes.Black,
                        new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                        XStringFormats.TopLeft);

                    yOffset += 20;
                }
                else if (employee is Developer developer)
                {
                    gfx.DrawString($"Мова програмування: {developer.ProgrammingLanguage}", regularFont, XBrushes.Black,
                        new XRect(50, yOffset, page.Width.Point, page.Height.Point),
                        XStringFormats.TopLeft);

                    yOffset += 20;
                }

                yOffset += 20;
            }

            document.Save(filePath);
        }

    }
}
