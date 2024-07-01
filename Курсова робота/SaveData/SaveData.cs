using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EmployeeLib;
using System.IO;
using System.Collections.Generic;

namespace SaveDataLib
{
    public static class SaveData
    {
        public static void SaveEmployeesToFile(IEnumerable<Employee> employees, string filePath)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(employees, settings);
            File.WriteAllText(filePath, json);
        }

        public static List<Employee> LoadEmployeesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };

                var employees = JsonConvert.DeserializeObject<List<Employee>>(json, settings);
                return employees ?? new List<Employee>();
            }
            return new List<Employee>();
        }
    }

}


