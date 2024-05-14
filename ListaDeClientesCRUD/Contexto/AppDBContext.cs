using ListaDeClientesCRUD.Models;
using Microsoft.EntityFrameworkCore;


namespace ListaDeClientesCRUD.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        //Modelos
        public DbSet<Cliente> Clientes { get; set; }
    }
}
