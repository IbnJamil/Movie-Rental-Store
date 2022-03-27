using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;
namespace vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _Context;
        public CustomerController()
        {
            _Context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }
        public ActionResult Index()
        {       
            if (User.IsInRole(RoleName.CanMangeMovie))
                return View();
            else return View("ReadOnly");
        }
        public ActionResult NewCustomer()
        {
            var customerPlusMembership = new ViewModelCustomer();
            customerPlusMembership.membershiptype = _Context.MemberShipType.ToList();
            return View(customerPlusMembership);
        }
        [HttpPost]
        public ActionResult CreateCustomer(ViewModelCustomer customerPlusMembership)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("NewCustomer");
            _Context.Customers.Add(customerPlusMembership.customers);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var customerDetails = _Context.Customers.Include(n=>n.MemberShipTypes).SingleOrDefault(x => x.Id == id);
            return View(customerDetails);
        }
        public ActionResult Delete(int id)
        {
            var deleteEntry = _Context.Customers.SingleOrDefault(x => x.Id == id);
            if (deleteEntry == null)
            {
                return RedirectToAction("Index");
            }
            _Context.Customers.Remove(deleteEntry);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}