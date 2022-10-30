using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PresentaionLayer.Models;
using BusinessObjects;

namespace PresentaionLayer.Controllers
{
    public class GenderController : Controller
    {
        // GET: Gender
        public ActionResult Index()
        {
            GenderBussiness gb = new GenderBussiness();

            var genderList = gb.GetAllGenders();

            return View(genderList);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GenderModel genModel)
        {
            GenderBussiness genderBussiness = new GenderBussiness();
            genderBussiness.AddGender(genModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            GenderBussiness genderBussiness = new GenderBussiness();
            GenderModel genderModel = genderBussiness.GetGenderById(Id);
            return View(genderModel);
        }

        [HttpPost]
        public ActionResult Edit(GenderModel genderModel)
        {
            GenderBussiness genderBussiness = new GenderBussiness();
            genderBussiness.UpdateGender(genderModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            GenderBussiness genderBussiness = new GenderBussiness();
            genderBussiness.DeleteGender(Id);
            return RedirectToAction("Index");
        }


    }
}