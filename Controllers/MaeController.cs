using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteFamilia.Models;
using System.ComponentModel.DataAnnotations;
using SiteFamilia.Database;

namespace SiteFamilia.Controllers
{
    public class MaeController : Controller
    {
        private DatabaseContext _db;
        public MaeController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Mae = _db.Maes.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {

            return View(new Mae());
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm]Mae mae)
        {
            if (ModelState.IsValid) {

            _db.Maes.Add(mae);
            _db.SaveChanges();
                return RedirectToAction("index",mae);
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm]Mae mae)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            return RedirectToAction("Index");
        }
    }
}