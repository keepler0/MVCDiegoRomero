using IntegradorEDI2024.Entidades;
using IntegradorEDI2024.Entidades.ViewModels.Brand;
using IntegradorEDI2024.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegradorEDI2024.Web.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IBrandsService _service;

        public BrandsController(IBrandsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var lista = _service?.GetList();
            return View(lista);
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BrandEditVm brandVm) 
        {
            if (!ModelState.IsValid)
            {
                return View(brandVm);
            }
            Brand brand = new Brand
            {
                BrandId = brandVm.BrandId,
                BrandName = brandVm.BrandName ?? "N/A"
            };
            if (_service.Exist(brand))
            {
                ModelState.AddModelError(string.Empty, "Registro existente");
                return View(brandVm);
            }
            _service.Save(brand);
            TempData["success"] = "Registro agregado!";
            return RedirectToAction("Index");
        }
    }
}
