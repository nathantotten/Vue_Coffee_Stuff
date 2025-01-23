using coffee_webapi.Models.CoffeeMachines;
using Microsoft.EntityFrameworkCore;

namespace coffee_webapi.Models;

public class CoffeeApiContext : DbContext
{
    public CoffeeApiContext(DbContextOptions<CoffeeApiContext> options)
    : base(options)
    {
    }

    public DbSet<CoffeeMachine> CoffeeMachines { get; set; } = null!;
}