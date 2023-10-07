using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecoCerto.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Telefone { get; set; }

        // Relação 1-para-N com a tabela Fornecedor
        public ICollection<Fornecedor> Fornecedores { get; set; }

        // Relação 1-para-N com a tabela Pedido
        public ICollection<Pedido> Pedidos { get; set; }

        // Relação 1-para-N com a tabela Pedido
        public ICollection<CarrinhoDeCompra> CarrinhoDeCompras { get; set; }

    }
}
