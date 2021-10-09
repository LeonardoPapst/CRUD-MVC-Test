using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC_Test.DAL;
using CRUD_MVC_Test.Models;

namespace CRUD_MVC_Test.Controllers
{
    public class PessoasController : Controller
    {
        private EFContext db = new EFContext();

        // GET: Pessoas
        public ActionResult Index()
        {
            ViewModel mymodel = new ViewModel();
            mymodel.Pessoas = db.Pessoas.AsEnumerable();
            mymodel.Pessoa = new Pessoa();
            return View(mymodel);
        }

        // GET: Pessoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PessoaId,Nome,TelefoneRes,Celular")] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return View(pessoa);
            }

            db.Pessoas.Add(pessoa);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

        // GET: Pessoas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            db.Pessoas.Remove(pessoa);
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
