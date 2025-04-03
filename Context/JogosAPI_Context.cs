using JogosAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace JogosAPI.Context
{
    public class JogosAPI_Context : DbContext
    {
       
            public JogosAPI_Context()
            {

            }
            public JogosAPI_Context(DbContextOptions<JogosAPI_Context> options) : base(options)
            {

            }

            public DbSet<Jogo> Jogo { get; set; }
            public DbSet<Usuario> Usuario { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=NOTE13-S28\\SQLEXPRESS; Database=JogosAPI; User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
                }
            }
        
    }
}
 
