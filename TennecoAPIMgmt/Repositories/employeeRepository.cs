using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennecoAPIMgmt.Models;

namespace TennecoAPIMgmt.Repositories
{
    public class employeeRepository
    {
        ApplicationDbContext entities = new ApplicationDbContext();
        public List<Employee > GetAllfactories()
        {
            return entities.Employees .ToList();
        }
        public Employee GetfactoryByID(int id)
        {
            Employee factory = entities.Employees .FirstOrDefault(a => a.Id  == id);
            return factory;
        }
        public void Insertfactory(Employee employee)
        {
            entities.Employees.Add(employee);
            entities.SaveChanges();
        }

    }
}