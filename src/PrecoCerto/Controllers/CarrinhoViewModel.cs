using System.Collections.Generic;
using PrecoCerto.Models;

namespace PrecoCerto.Controllers
{
    public class CarrinhoViewModel
    {
        // Coleção de itens no carrinho de compras
        public IEnumerable<CarrinhoDeCompra> CarrinhoDeCompras { get; set; }

        // Lista de produtos associados ao carrinho de compras
        private List<Produto> _produtos;

        public List<Produto> Produtos
        {
            get
            {
                if (_produtos == null)
                {
                    _produtos = new List<Produto>(); // Inicializa a lista se estiver nula
                }
                return _produtos;
            }
            set { _produtos = value; }
        }

        public decimal ValorTotal { get; internal set; }
    }
}
