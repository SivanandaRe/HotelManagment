using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentaionLayer.Controllers
{
    public class AddressTypeController : Controller
    {
        // GET: AddressType
      
        public ActionResult Index()
        {
            AddressTypeBusiness atb = new AddressTypeBusiness();

            var addressTypeList = atb.GetAllAddressTypes();


            return View(addressTypeList);
        }




    }
}