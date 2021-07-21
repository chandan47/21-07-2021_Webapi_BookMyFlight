using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication38.Models;

namespace WebApplication38.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeRepository _repository;
        
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public List<Employee> Get()
        {
            return _repository.GetAllEmployees();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public Employee Get(int id)
        {
            return _repository.GetEmployeeById(id);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public Employee Post(Employee employee)
        {
            return _repository.AddEmployee(employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public string Delete(int id)
        {
            _repository.DeleteEmployee(id);
            return "record deleted successfully";
        }

        [HttpPut]
        [Route("api/[controller]")]
        public string Update(Employee employee)
        {
            _repository.UpdateEmployee(employee);
            return "record updated successfully";
        }
    }
}
