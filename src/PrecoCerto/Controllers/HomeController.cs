using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrecoCerto.Models;
using System.Diagnostics;
using System.Linq;

namespace PrecoCerto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index([FromQuery] string Busca)
        {
            IQueryable<Produto> produtosQuery = _appDbContext.produtos;

            if (!string.IsNullOrEmpty(Busca))
            {
                produtosQuery = produtosQuery.Where(p => p.Nome.ToUpper().Contains(Busca.ToUpper()));
            }

            var produtos = await produtosQuery.ToListAsync();

            return View(produtos);
        }

        public IActionResult Cupons()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}