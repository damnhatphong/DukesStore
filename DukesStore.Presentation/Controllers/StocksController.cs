using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DukesStore.ApplicationCore.Entities;
using DukesStore.Persistence;
using DukesStore.ApplicationCore.Common;

namespace DukesStore.Presentation.Controllers
{
    public class StocksController : Controller
    {
        private readonly IDukesEShopContext _context;

        public StocksController(IDukesEShopContext context)
        {
            _context = context;
        }

        // GET: Stocks
        public async Task<IActionResult> Index()
        {
            var dukesEShopContext = _context.Stocks.Include(s => s.Product).Include(s => s.Store);
            return View(await dukesEShopContext.ToListAsync());
        }

        // GET: Stocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stocks = await _context.Stocks
                .Include(s => s.Product)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.StoreId == id);
            if (stocks == null)
            {
                return NotFound();
            }

            return View(stocks);
        }

        // GET: Stocks/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName");
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName");
            Stocks stock = new Stocks();
            return View(stock);
        }

        // POST: Stocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoreId,ProductId,Quantity")] Stocks stocks)
        {
            if (ModelState.IsValid)
            {
                _context.Stocks.Add(stocks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", stocks.ProductId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", stocks.StoreId);
            return View(stocks);
        }

        // GET: Stocks/Edit/5
        public async Task<IActionResult> Edit(int? id, int? productId)
        {
            if (id == null || productId == null)
            {
                return NotFound();
            }

            var stocks = await _context.Stocks
                .Include(s => s.Product)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.StoreId == id && m.ProductId == productId);

            if (stocks == null)
            {
                return NotFound();
            }

            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", stocks.ProductId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", stocks.StoreId);
            return View(stocks);
        }

        // POST: Stocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int productId, [Bind("StoreId,ProductId,Quantity")] Stocks stocks)
        {
            if (id != stocks.StoreId || productId != stocks.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stocks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StocksExists(stocks.StoreId))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductName", stocks.ProductId);
            ViewData["StoreId"] = new SelectList(_context.Stores, "StoreId", "StoreName", stocks.StoreId);
            return View(stocks);
        }

        // GET: Stocks/Delete/5
        public async Task<IActionResult> Delete(int? id,int? productId)
        {
            if (id == null || productId == null)
            {
                return NotFound();
            }

            var stocks = await _context.Stocks
                .Include(s => s.Product)
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.StoreId == id && m.ProductId == productId);

            if (stocks == null)
            {
                return NotFound();
            }

            return View(stocks);
        }

        // POST: Stocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id,int productId)
        {
            var stocks = await _context.Stocks.FindAsync(id);
            _context.Stocks.Remove(stocks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StocksExists(int id)
        {
            return _context.Stocks.Any(e => e.StoreId == id);
        }
    }
}
