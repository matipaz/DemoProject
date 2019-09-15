using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Entities;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace DemoProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly DemoDbContext dbContext;

        public ProductController(DemoDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
           List<ProductViewModel> productsList = new List<ProductViewModel>();
           productsList= dbContext.Products.ToList();          
            return View(productsList);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
                return NotFound();


            var product = await dbContext.Products.SingleOrDefaultAsync(m => m.Id == id);

            if (product == null)
                return NotFound();
     
            return View("~/Views/Product/AddOrUpdate.cshtml", product);
        }

        public IActionResult Add()
        {
            ProductViewModel productVM = new ProductViewModel();
            productVM.Id = 0;
            return View("~/Views/Product/AddOrUpdate.cshtml", productVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(ProductViewModel productVM)
        {
            if (ModelState.IsValid)
            {
             
                if (productVM.Id == 0) { 
                        dbContext.Add(productVM);
                }
                else
                        dbContext.Update(productVM);

                        await dbContext.SaveChangesAsync();
          
                return RedirectToAction("Index");
            }
            else
            {
                return View(productVM);

            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null|| id ==0)
                return NotFound();           
            var product = await dbContext.Products
                .SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)      
                return NotFound();
            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}