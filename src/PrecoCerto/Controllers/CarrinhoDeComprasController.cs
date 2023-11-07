using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrecoCerto.Models;

namespace PrecoCerto.Controllers
{
    public class CarrinhoDeComprasController : Controller
    {
        private readonly AppDbContext _context;

        public CarrinhoDeComprasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CarrinhoDeCompras
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CarrinhoDeCompras.Include(c => c.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CarrinhoDeCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarrinhoDeCompras == null)
            {
                return NotFound();
            }

            var carrinhoDeCompra = await _context.CarrinhoDeCompras
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrinhoDeCompra == null)
            {
                return NotFound();
            }

            return View(carrinhoDeCompra);
        }

        // GET: CarrinhoDeCompras/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: CarrinhoDeCompras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeProduto,QuantidadeItens,ValorTotal,UsuarioId")] CarrinhoDeCompra carrinhoDeCompra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrinhoDeCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", carrinhoDeCompra.UsuarioId);
            return View(carrinhoDeCompra);
        }

        // GET: CarrinhoDeCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarrinhoDeCompras == null)
            {
                return NotFound();
            }

            var carrinhoDeCompra = await _context.CarrinhoDeCompras.FindAsync(id);
            if (carrinhoDeCompra == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", carrinhoDeCompra.UsuarioId);
            return View(carrinhoDeCompra);
        }

        // POST: CarrinhoDeCompras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeProduto,QuantidadeItens,ValorTotal,UsuarioId")] CarrinhoDeCompra carrinhoDeCompra)
        {
            if (id != carrinhoDeCompra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrinhoDeCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarrinhoDeCompraExists(carrinhoDeCompra.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", carrinhoDeCompra.UsuarioId);
            return View(carrinhoDeCompra);
        }

        // GET: CarrinhoDeCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarrinhoDeCompras == null)
            {
                return NotFound();
            }

            var carrinhoDeCompra = await _context.CarrinhoDeCompras
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrinhoDeCompra == null)
            {
                return NotFound();
            }

            return View(carrinhoDeCompra);
        }

        // POST: CarrinhoDeCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarrinhoDeCompras == null)
            {
                return Problem("Entity set 'AppDbContext.CarrinhoDeCompras'  is null.");
            }
            var carrinhoDeCompra = await _context.CarrinhoDeCompras.FindAsync(id);
            if (carrinhoDeCompra != null)
            {
                _context.CarrinhoDeCompras.Remove(carrinhoDeCompra);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarrinhoDeCompraExists(int id)
        {
          return _context.CarrinhoDeCompras.Any(e => e.Id == id);
        }
    }
}
