using DatingAppTest.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingAppTest.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {}

        public DbSet<Value> Values { get; set; }
        
    }
}