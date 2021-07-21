using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication38.Models
{
    public class EmployeeSQLImpl : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeSQLImpl(EmployeeDbContext context)
        {
            _context = context;
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            Employee emp = GetEmployeeById(id);
            _context.Employees.Remove(emp);
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(emp => emp.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
