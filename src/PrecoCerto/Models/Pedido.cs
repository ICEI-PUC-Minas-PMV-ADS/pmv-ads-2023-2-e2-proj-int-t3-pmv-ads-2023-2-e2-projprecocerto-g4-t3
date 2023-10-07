using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecoCerto.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        public string Itens { get; set; }

        public double Valor { get; set; }

        public DateTime Data { get; set; }

        public DateTime Horario { get; set; }

        public double Total { get; set; }

        // Chave estrangeira para Usuario
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
