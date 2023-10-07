using Microsoft.EntityFrameworkCore;

namespace PrecoCerto.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<CarrinhoDeCompra> CarrinhoDeCompras { get; set; }

        public DbSet<Produto> produtos { get; set; }
    }
}
