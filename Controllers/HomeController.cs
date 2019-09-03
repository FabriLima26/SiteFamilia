using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteFamilia.Models;

namespace SiteFamilia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm]Usuario usuario)
        {
            if(usuario.Email.Equals("fabricio_jobbosat@outlook.com") && usuario.Senha.Equals("123456"))
            {
                return Redirect("/mae/perfil");
            }
            else
            {
                ViewBag.Mensagem = "Os dados são inválidos";
            return View();
            }
        }
    }
}