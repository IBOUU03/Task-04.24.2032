using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Task3.Models;

namespace Task3.DataAccess
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options) { }

        public DbSet<SerFeature> Table_1 { get; set;}
        }
}
