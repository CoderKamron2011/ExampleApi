using ExampleApi.Models.Employies;
using Microsoft.EntityFrameworkCore;

namespace ExampleApi.Brokers.Storage
{
    public partial class StorageBroker
    {
        public DbSet<Employee> Employees{ get; set; }
        public ValueTask<Employee> InsertEmployeeAsync(Employee employee) =>
            this.InsertAsync(employee);

        public IQueryable<Employee> SelectAllEmployees() =>
            this.SelectAll<Employee>();

        public ValueTask<Employee> SelectEmployeeByIdAsync(int employeeId) =>
            this.SelectAsync<Employee>(employeeId);

        public ValueTask<Employee> UpdateEmployeeAsync(Employee employe) =>
            this.UpdateAsync<Employee>(employe);

        public ValueTask<Employee> DeleteEmployeeAsync(Employee employe) =>
            this.DeleteAsync<Employee>(employe);
    }
}
