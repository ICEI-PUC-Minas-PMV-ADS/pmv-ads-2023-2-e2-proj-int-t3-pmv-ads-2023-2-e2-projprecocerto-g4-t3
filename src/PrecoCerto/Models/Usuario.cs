using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecoCerto.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Endereco")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Telefone")]
        public string Telefone { get; set; }

        // Relação 1-para-N com a tabela Fornecedor
        public ICollection<Fornecedor> Fornecedores { get; set; }

        // Relação 1-para-N com a tabela Pedido
        public ICollection<Pedido> Pedidos { get; set; }

        // Relação 1-para-N com a tabela Pedido
        public ICollection<CarrinhoDeCompra> CarrinhoDeCompras { get; set; }

    }
}
