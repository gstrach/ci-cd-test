
using Microsoft.EntityFrameworkCore;

public class Customer
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
}

public class CustomerContext(DbContextOptions<CustomerContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
}


