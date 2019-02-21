using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.API.Data.Models.Entities;

namespace SchoolManagementSystem.API.Data
{
    public class DataContext: DbContext
    {
         public DataContext(DbContextOptions<DataContext>  options) : base (options) {}

         public DbSet<Student> Students { get; set; }
    }
}