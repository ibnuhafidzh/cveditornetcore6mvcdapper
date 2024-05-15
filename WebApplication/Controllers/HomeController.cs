using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;
using WebApplication.Models;
using WebApplication.Repositories;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IData dataRepository;

        public HomeController(IData Data)
        {
            this.dataRepository = Data;
        }

        public async Task<IActionResult> Index()
        {
            var data = await dataRepository.Get();

            return View(data);
        }
        public async Task<IActionResult> Details(String id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var product = await dataRepository.Find(id);

            if (product == null)
            {
                return BadRequest();
            }

            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DataModel model)
        {
            if (ModelState.IsValid)
            {
                await dataRepository.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Edit(String id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var product = await dataRepository.Find(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(String id, DataModel model)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var product = await dataRepository.Find(id);

            if (product == null)
            {
                return BadRequest();
            }
            await dataRepository.Update(model);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(String id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var product = await dataRepository.Find(id);

            if (product == null)
            {
                return BadRequest();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(String id)
        {
            var product = await dataRepository.Find(id);
            await dataRepository.Remove(product);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
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