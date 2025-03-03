﻿using ExampleApi.Models.Employies;
using ExampleApi.Services.Foundation;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ExampleApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : RESTFulController
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController()
        {
            this.employeeService = employeeService;
        }
        [HttpPost]
        public async ValueTask<ActionResult<Employee>> PostEmployeeAsync([FromForm] Employee employee)
        {
            var postedEmployee =
                await this.employeeService.AddEmployeeAsync(employee);

            return Created();
        }
        [HttpGet]
        public async ValueTask<ActionResult<Employee>> GetByIdEmployeeAsync([FromForm] int employeeId)
        {
            var getByIdEmployee =
                await this.employeeService.RetrieveEmployeeByIdAsync(employeeId);

            return Ok(getByIdEmployee);
        }
        [HttpDelete]
        public async ValueTask<ActionResult<Employee>> DeleteEmployeeAsync([FromForm] Employee employee)
        {
            var deleteEmployee =
                await this.employeeService.RemoveEmployeeByIdAsync(employee);

            return Ok(deleteEmployee);
        }
        [HttpGet]
        public async ValueTask<ActionResult<Employee>> GetAllEmployeeAsync()
        {
            var result =
                this.employeeService.RetrieveAllEmployee();

            return Created();
        }
        [HttpPut]
        public async ValueTask<ActionResult<Employee>> UpdateEmployeeAsync([FromForm] Employee employee)
        {
            var updateEmployee =
                await this.employeeService.ModifyEmployeeAsync(employee);


            return Ok(updateEmployee);
        }
    }
}
