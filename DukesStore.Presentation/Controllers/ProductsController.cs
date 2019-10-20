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
using DukesStore.ApplicationCore.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace DukesStore.Presentation.Controllers
{   
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IDukesEShopContext _context;

        public ProductsController(IDukesEShopContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var dukesEShopContext = _context.Products.Include(p => p.Brand).Include(p => p.Category).Include(p => p.Price).Include(p => p.Price.Currency);
            return View(await dukesEShopContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Price)
                .Include(p => p.Price.Currency)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandName");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["Currencies"] = new SelectList(_context.Currencies, "CurrencyId", "CurrencyUnit");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreationalViewModel products)
        {

            if (ModelState.IsValid)
            {
                //Create new price for new product
                products.Price.CreatedDate = DateTime.Today;
                products.Price.Description = $"New Price From Product: {products.Product.ProductName}";
                _context.Prices.Add(products.Price);
                await _context.SaveChangesAsync();

                //Add new product
                products.Product.PriceId = products.Price.PriceId;
                _context.Products.Add(products.Product);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandName", products.Product.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", products.Product.CategoryId);
            ViewData["Currencies"] = new SelectList(_context.Currencies, "CurrencyId", "CurrencyUnit", products.Price.CurrencyId);
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Price)
                .Include(p => p.Price.Currency)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            if (products == null)
            {
                return NotFound();
            }

            var productVM = new ProductCreationalViewModel
            {
                Product = products,
                Price = products.Price
            };
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandName", products.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", products.CategoryId);
            ViewData["Currencies"] = new SelectList(_context.Currencies, "CurrencyId", "CurrencyUnit", products.Price.CurrencyId);
            return View(productVM);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductCreationalViewModel productVM)
        {
            if (id != productVM.Product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var currentProductInstanceInDatabase = await _context.Products.Include(p => p.Price).Include(c => c.Price.Currency).AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == id);


                    if (currentProductInstanceInDatabase.Price.Amount != productVM.Price.Amount || productVM.Price.CurrencyId != currentProductInstanceInDatabase.Price.CurrencyId)
                    {
                        var newProductCurrency = await _context.Currencies.Where(p => p.CurrencyId == productVM.Price.CurrencyId).Select(c => c.CurrencyUnit).AsNoTracking().SingleOrDefaultAsync();
                        productVM.Price.Description = $"{currentProductInstanceInDatabase.ProductName}'s price has changed from {currentProductInstanceInDatabase.Price.Amount} {currentProductInstanceInDatabase.Price.Currency.CurrencyUnit} To {productVM.Price.Amount} {newProductCurrency}";
                        productVM.Price.CreatedDate = DateTime.Today;
                        productVM.Price.EffectiveDate = DateTime.Today;

                        _context.Update(productVM.Price);
                        await _context.SaveChangesAsync();
                    }

                    
                    _context.Update(productVM.Product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(productVM.Product.ProductId))
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
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "BrandName", productVM.Product.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", productVM.Product.CategoryId);
            ViewData["Currencies"] = new SelectList(_context.Currencies, "CurrencyId", "CurrencyUnit", productVM.Price.CurrencyId);
            return View(productVM);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .Include(p => p.Price)
                .Include(p=>p.Price.Currency)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await _context.Products.FindAsync(id);
            var productPrice = await _context.Prices.FindAsync(products.PriceId);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();

            _context.Prices.Remove(productPrice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
