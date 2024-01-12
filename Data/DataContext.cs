using Microsoft.EntityFrameworkCore;
using AfsarZStudentDataBase.Model;

namespace AfsarZStudentDataBase.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
