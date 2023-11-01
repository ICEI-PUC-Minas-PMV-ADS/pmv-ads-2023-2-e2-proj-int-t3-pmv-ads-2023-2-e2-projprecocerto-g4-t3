using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecoCerto.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Setor!")]
        public string Setor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Marca!")]
        public String Marca { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Quantidade!")]
        public int Quantidade { get; set; }

        [Display(Name = "Estoque")]
        [Required(ErrorMessage = "Obrigatório informar se tem em Estoque!")]
        public bool EmEstoque { get; set; }

        [Display(Name = "Oferta")]
        [Required(ErrorMessage = "Obrigatório informar se esta em Oferta!")]
        public bool EmOferta { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Preco!")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Descricao!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Validade!")]
        public DateTime Validade { get; set; }

        [Display(Name = "Supermercados")]
        [Required(ErrorMessage = "Obrigatório informar o Supermercado!")]
        public TipoSupermercado Tipo { get; set; }
    }

    public enum TipoSupermercado
    {
        SupermercadoBh,
        Carrefour,
        Epa
    }
}