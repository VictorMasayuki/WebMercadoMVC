using Microsoft.EntityFrameworkCore;
using WebMercadoMVC.Models;

namespace WebMercadoMVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
 
    }
}
