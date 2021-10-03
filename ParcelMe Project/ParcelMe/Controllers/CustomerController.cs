using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using ParcelMe.Models;
using Data;

namespace ParcelMe.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerRepo repo;

        public CustomerController(ICustomerRepo _repo)
        {
            repo = _repo;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult List()
        {
            return View(Mapper.Map(repo.DisplayAll()));
        }

        // GET: CustomerController/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Customer cust)
        {
            if (ModelState.IsValid)
            {
                repo.Register(cust);
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            var data = repo.Login(login.Username,login.Password);
            if (ModelState.IsValid)
            {
                if (data != null)
                {
                    HttpContext.Session.SetString("SessionId", data.Id.ToString());
                    //Session["id"] = data.Id;
                    HttpContext.Session.SetString("SessionUsername", login.Username.ToString());
                    //Session["Username"] = login.Username;
                    return RedirectToAction("Profile","Customer");
                }
                else
                {
                    ViewBag.Message = "Credentials are Incorrect";
                }
            }
            return View();
        }

        public IActionResult Profile()
        {
            var uname = HttpContext.Session.GetString("SessionUsername");
            if ( uname != null)
            {
                return View(Mapper.Map(repo.Profile(uname)));
            }
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
