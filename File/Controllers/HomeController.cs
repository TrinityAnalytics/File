using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using File.Models;

namespace File.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ParentViewModel parentViewModel = new ParentViewModel();
            parentViewModel.listChilds = new List<ChildViewModel>();
            parentViewModel.listChilds.Add(new ChildViewModel { Description = "Photo 1" });
            parentViewModel.listChilds.Add(new ChildViewModel { Description = "Photo 2" });
            parentViewModel.listChilds.Add(new ChildViewModel { Description = "Photo 3" });
            parentViewModel.name = "Salut Florian :D";
            return View(parentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ParentViewModel model) //Pour récupérer les données, il faut faire un bind sinon, tu récupères un modèle vide :)
        {
            return Ok(model.listChilds.Count);
        }
    }
}
