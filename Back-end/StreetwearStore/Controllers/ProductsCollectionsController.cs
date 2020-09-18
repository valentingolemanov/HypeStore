using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StreetwearStore.Web.Controllers
{
    public class ProductsCollectionsController : Controller
    {
        // GET: ProductsCollections
        [HttpGet]
        public IActionResult GetAll()
        {
            return View();
        }


        // GET: ProductsCollections/Details/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            return View();
        }


        // POST: ProductsCollections/Create
        [HttpPost]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // POST: ProductsCollections/Edit/5
        [HttpPost]
        [Route("{id:int}")]
        public async Task<IActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
