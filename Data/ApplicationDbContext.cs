using DouglasRent.Models;
using Microsoft.EntityFrameworkCore;

namespace DouglasRent.Data
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //Constructor
        {
        }
        
        public DbSet<EmprestimosModel> Emprestimos { get; set; } // Table in the database
                
        }
    }

