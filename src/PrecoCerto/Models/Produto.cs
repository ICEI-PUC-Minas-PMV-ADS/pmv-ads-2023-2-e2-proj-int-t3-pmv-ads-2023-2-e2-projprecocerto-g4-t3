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
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Descricao!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Validade!")]
        public DateTime Validade { get; set; }

        [Display(Name = "Supermercados")]
        [Required(ErrorMessage = "Obrigatório informar o Supermercado!")]
        public TipoSupermercado Tipo { get; set; }

        // Propriedade para armazenar os dados da imagem (formato binário)
        [Display(Name = "Imagem do Produto")]
        [Required(ErrorMessage = "Obrigatório fornecer uma imagem.")]
        public byte[] Imagem { get; set; }

        // Propriedade para o tipo MIME da imagem
        [Display(Name = "Tipo de Imagem")]
        [Required(ErrorMessage = "Obrigatório informar o tipo da imagem.")]
        public string ImagemMimeType { get; set; }

        // Propriedade para armazenar os dados da imagem do modal (formato binário)
        [Display(Name = "Imagem do Modal")]
        public byte[] ModalImagem { get; set; }

        // Propriedade para o tipo MIME da imagem do modal
        [Display(Name = "Tipo de Imagem do Modal")]
        public string ModalImagemMimeType { get; set; }
    }

    public enum TipoSupermercado
    {
        SupermercadoBh,
        Carrefour,
        Epa
    }
}