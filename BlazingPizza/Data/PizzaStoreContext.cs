using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;
public class PizzaStoreContext : DbContext
{
    public DbSet<PizzaSpecial> Specials { get; set; }
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {

    }
}
