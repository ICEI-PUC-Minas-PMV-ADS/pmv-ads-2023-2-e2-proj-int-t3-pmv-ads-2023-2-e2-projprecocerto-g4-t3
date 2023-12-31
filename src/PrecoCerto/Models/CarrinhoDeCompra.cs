﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecoCerto.Models
{
    [Table("CarrinhoDeCompras")]
    public class CarrinhoDeCompra
    {
        [Key]
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public int QuantidadeItens { get; set; }

        public decimal ValorTotal { get; set; }

        // Chave estrangeira para Usuario
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
