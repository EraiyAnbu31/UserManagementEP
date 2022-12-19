using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagementEP.Models;

namespace UserManagementEP.Controllers
{
    public class userDetailsController : Controller
    {
        // GET: RegisteredUsers
        public ActionResult Index1()
        {
            using (training_dbEntities dbmodel = new training_dbEntities())
            {
                return View(dbmodel.users_EP.ToList());
            }
        }



        // GET: RegisteredUsers/Details/5
        public ActionResult Details(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.users_EP.Where(x => x.UserID == id).FirstOrDefault());
            }
        }



        // GET: RegisteredUsers/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: RegisteredUsers/Create
        [HttpPost]
        public ActionResult Create(users_EP customer)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    dbModel.users_EP.Add(customer);
                    dbModel.SaveChanges();
                }



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Insertion/Edit/5
        public ActionResult Edit(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.users_EP.Where(x => x.UserID == id).FirstOrDefault());
            }



        }



        // POST: Insertion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, users_EP customer)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    dbModel.Entry(customer).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                // TODO: Add update logic here



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Insertion/Delete/5
        public ActionResult Delete(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.users_EP.Where(x => x.UserID == id).FirstOrDefault());
            }
        }



        // POST: Insertion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    users_EP customer = dbModel.users_EP.Where(x => x.UserID == id).FirstOrDefault();
                    dbModel.users_EP.Remove(customer);
                    dbModel.SaveChanges();
                }
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
