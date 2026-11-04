namespace SimuladoIronFit.Api.Controllers
{
    using global::IronFit.Models;
    using IronFit.Data;
    using IronFit.Models;
    using Microsoft.AspNetCore.Mvc;
    using SimuladoIronFit.Api.Data.IronFit.Data;

    namespace IronFit.Controllers
    {
        public class PersonalsController : Controller
        {
            private Banco db;

            public PersonalsController(Banco banco)
            {
                db = banco;
            }

            public IActionResult Index(string busca)
            {
                var lista = db.Personals.ToList();

                if (!string.IsNullOrEmpty(busca))
                {
                    lista = lista.Where(p =>
                        p.Nome.Contains(busca)).ToList();
                }

                return View(lista);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Personal p)
            {
                db.Personals.Add(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            public IActionResult Edit(int id)
            {
                var p = db.Personals.Find(id);

                return View(p);
            }

            [HttpPost]
            public IActionResult Edit(Personal p)
            {
                db.Personals.Update(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
