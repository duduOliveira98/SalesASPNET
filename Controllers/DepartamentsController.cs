using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Pages;
using Microsoft.AspNetCore.Mvc;
using SalesForceMVC.Models;

namespace SalesForceMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departament> departamento = new List<Departament>();
            departamento.Add(new Departament { Id = 1, Name = "Eletronicos" });
            departamento.Add(new Departament { Id = 2, Name = "Roupas" });

            return View(departamento);
        }

        public IActionResult Edit()
        {
            return PartialView();
        }

    }
}
