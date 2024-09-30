using ExampleApi.Models.Employies;

namespace ExampleApi.Brokers.Storage
{
    public interface IStorageBroker
    {
        ValueTask<Employee> InsertEmployeeAsync(Employee employee);
        IQueryable<Employee> SelectAllEmployees();
        ValueTask<Employee> SelectEmployeeByIdAsync(int employeeId);
        ValueTask<Employee> UpdateEmployeeAsync(Employee employe);
        ValueTask<Employee> DeleteEmployeeAsync(Employee employe);
    }
}
