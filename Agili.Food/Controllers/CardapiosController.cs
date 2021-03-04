using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Agili.Food.AcessoDados.Context;
using Agili.Food.Dominio;
using Agili.Food.ViewModels.Cardapio;
using AutoMapper;

namespace Agili.Food.Controllers
{
    public class CardapiosController : Controller
    {
        private AgiliFoodDbContext db = new AgiliFoodDbContext();

        // GET: Cardapios
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Cardapio>, List<CardapioIndexViewModel>>(db.Cardapio.ToList()));
        }

        // GET: Cardapios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cardapios/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeFornecedor,NomePedido,Tipo,Valor,DataCad")] CardapioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Cardapio cardapio = Mapper.Map<CardapioViewModel, Cardapio>(viewModel);
                db.Cardapio.Add(cardapio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Cardapios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cardapio cardapio = db.Cardapio.Find(id);
            if (cardapio == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Cardapio, CardapioViewModel>(cardapio));
        }

        // POST: Cardapios/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeFornecedor,NomePedido,Tipo,Valor,DataCad")] CardapioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Cardapio cardapio = Mapper.Map<CardapioViewModel, Cardapio>(viewModel);
                db.Entry(cardapio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Cardapios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cardapio cardapio = db.Cardapio.Find(id);
            if (cardapio == null)
            {
                return HttpNotFound();
            }
            return View(cardapio);
        }

        // POST: Cardapios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cardapio cardapio = db.Cardapio.Find(id);
            db.Cardapio.Remove(cardapio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
