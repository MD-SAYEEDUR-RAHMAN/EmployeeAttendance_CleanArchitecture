using EmployeeAttendance.Domain;
using EmployeeAttendance.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeAttendance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employee;

        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }
        // GET: api/<EMployeeController>
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            var data = await employee.GetAsync();
            return Ok(data);
        }

        // GET api/<EMployeeController>/5
        [HttpGet("{id}")]
        public async Task <IActionResult>GetById(int id)
        {
            var data= await employee.GetByIdAsync(id);
            return Ok(data);
        }

        // POST api/<EMployeeController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Employee employeeDto)
        {
            var result = await employee.AddAsync(employeeDto);
            return Ok(result);
        }

        // PUT api/<EMployeeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Updata([FromBody] Employee employeeDto)
        {
            var result =await employee.UpdateAsync(employeeDto);
            return Ok(result);
        }

        // DELETE api/<EMployeeController>/5
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id)
        {
            var result =await employee.DeleteAsync(id);
            return Ok(result);
        }
    }
}
