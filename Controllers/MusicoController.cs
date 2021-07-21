using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POO_Backend_Rec3.Models;

namespace POO_Backend_Rec3.Controllers
{
    public class MusicoController : Controller
    {

        Musico m = new Musico();

        public IActionResult Index()
        {
            m.Nome = "Paulo";
            ViewBag.nome = m.Nome;
            ViewBag.Saudacao = m.ShowName();

            return View();
        }
        
        public IActionResult MusicoFoda(){
            m.Nome = "Michale Jackson";
            ViewBag.nome = m.Nome;
            ViewBag.Saudacao = m.ShowName();
            return View();
        } 

    }
}