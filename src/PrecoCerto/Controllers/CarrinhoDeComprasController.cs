using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrecoCerto.Models;
using System.Linq;

namespace PrecoCerto.Controllers
{
    public class CarrinhoDeComprasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly CarrinhoDeCompra _carrinho;

        public CarrinhoDeComprasController(AppDbContext context, CarrinhoDeCompra carrinho)
        {
            _context = context;
            _carrinho = carrinho;
        }

        private decimal CalcularValorTotal(CarrinhoViewModel carrinhoViewModel)
        {
            return carrinhoViewModel.Produtos.Sum(produto => produto.Preco);
        }

        public IActionResult Index()
        {
            CarrinhoViewModel carrinhoViewModel = ObterCarrinhoViewModel();

            // Calcula o valor total do carrinho
            carrinhoViewModel.ValorTotal = carrinhoViewModel.Produtos.Sum(p => p.Preco);

            return View(carrinhoViewModel);
        }

        public IActionResult AdicionarAoCarrinho(int id)
        {
            var produto = _context.produtos.Find(id);
            if (produto != null)
            {
                CarrinhoViewModel carrinhoViewModel = ObterCarrinhoViewModel();

                // Adiciona o produto ao carrinho de produtos na ViewModel
                carrinhoViewModel.Produtos.Add(produto);

                // Recalcula o valor total
                carrinhoViewModel.ValorTotal = CalcularValorTotal(carrinhoViewModel);

                // Atualiza a sessão com a ViewModel atualizada
                SalvarCarrinhoViewModel(carrinhoViewModel);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoverDoCarrinho(int id)
        {
            CarrinhoViewModel carrinhoViewModel = ObterCarrinhoViewModel();

            // Remove o produto do carrinho de produtos na ViewModel
            var produtoToRemove = carrinhoViewModel.Produtos.FirstOrDefault(p => p.Id == id);
            if (produtoToRemove != null)
            {
                carrinhoViewModel.Produtos.Remove(produtoToRemove);

                // Recalcula o valor total
                carrinhoViewModel.ValorTotal = CalcularValorTotal(carrinhoViewModel);

                // Atualiza a sessão com a ViewModel atualizada
                SalvarCarrinhoViewModel(carrinhoViewModel);
            }

            return RedirectToAction("Index");
        }

        private CarrinhoViewModel ObterCarrinhoViewModel()
        {
            // Obtém a ViewModel da sessão
            return HttpContext.Session.Get<CarrinhoViewModel>("CarrinhoViewModel") ?? new CarrinhoViewModel();

        }

        private void SalvarCarrinhoViewModel(CarrinhoViewModel carrinhoViewModel)
        {
            // Salva a ViewModel na sessão
            HttpContext.Session.Set("CarrinhoViewModel", carrinhoViewModel);
        }
    }
}
