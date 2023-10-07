using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrecoCerto.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal CNPJ { get; set; }

        public string Endereco { get; set; }

        // Chave estrangeira para Usuario
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
