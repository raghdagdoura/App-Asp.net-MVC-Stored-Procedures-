using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using procedure.DAL;

namespace procedure.Controllers
{
    public class ComputerController : Controller
    {
    ComputerDAL _computerDAL = new ComputerDAL();

    // GET: Computer
    public ActionResult Index()
        {

      var computerlist = _computerDAL.GetAllComputer();

      return View(computerlist);
        }

        // GET: Computer/Details/5
        public ActionResult Details(int id)
        {
           return View();
         }

    // GET: Computer/Create
    public ActionResult Create()
        {
            return View();
        }

        // POST: Computer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Computer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Computer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Computer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Computer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
