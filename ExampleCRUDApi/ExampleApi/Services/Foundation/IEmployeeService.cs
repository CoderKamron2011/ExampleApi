﻿using ExampleApi.Models.Employies;

namespace ExampleApi.Services.Foundation
{
    public interface IEmployeeService
    {
        ValueTask<Employee> AddEmployeeAsync(Employee employee);
        IQueryable<Employee> RetrieveAllEmployee();
        ValueTask<Employee> RemoveEmployeeByIdAsync(Employee employeeId);
        ValueTask<Employee> RetrieveEmployeeByIdAsync(int employeeId);
        ValueTask<Employee> ModifyEmployeeAsync(Employee employee);
    }
}
