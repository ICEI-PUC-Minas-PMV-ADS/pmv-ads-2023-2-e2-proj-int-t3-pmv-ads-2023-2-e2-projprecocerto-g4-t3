using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecoCerto.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Setor { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public bool EmEstoque { get; set; }

        public bool EmOferta { get; set; }

        public double Preco { get; set; }

        public string Descricao { get; set; }

        public int Garantia { get; set; }

        public DateTime Validade { get; set; }
    }
}
