using Microsoft.EntityFrameworkCore;
using API.Models;
namespace API.Data
{
    public class AppDataContext: DbContext{
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options){}
      public DbSet<Imc> Imcs {get; set;}
      public DbSet<Usuario> Usuarios {get; set;}  
    }
}