using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EmployeeWebAPI.Model;

namespace EmployeeWebAPI.Config
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public ConnectionContext(DbContextOptions<ConnectionContext> options)
        : base(options){ }
    }
}
