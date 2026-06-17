using Microsoft.AspNetCore.Mvc;
using uro.data;
using uro.viewModels;

namespace uro.Controllers
{
    public class AlighnedCountrysController : Controller
    {
        private readonly UROContext _context;
        public AlighnedCountrysController
            (
                UROContext context
            )
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var countries = _context.AlighnedCountrys
                .Select(c => new ACIndexViewModel
                {
                    Id = c.Id,
                    Country = c.Country
                });

            return View(countries);
        }
        public async Task<IActionResult> Create()
        {


            return View();
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var country = _context.AlighnedCountrys
                .Where(c => c.Id == id)
                .Select(c => new ACUpdateViewModel
                {
                    Id = c.Id,
                    Country = c.Country
                })
                .FirstOrDefault();

            return View(country);
        }
        public async Task<IActionResult> Delete(int? id)
        { 

            var countries = _context.AlighnedCountrys
                .Select(c => new ACDeleteViewModel
                {
                    Id = c.Id,
                    Country = c.Country
                });

            return View(countries);
        }
    }
}
