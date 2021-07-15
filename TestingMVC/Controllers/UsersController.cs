using TestingMVC.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingMVC.ViewModels;

namespace TestingMVC.Controllers
{
    public class UsersController : Controller
    {
        // Call DB
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Users
        public ActionResult Index()
        {
            var users = _context.Usuarios.ToList();

            return View(users);
        }

        public ActionResult Details(int id)
        {
            var user = _context.Usuarios.Include(u => u.Gender).SingleOrDefault(u => u.Id == id);

            if (user == null)
                return HttpNotFound();

            return View(user);
        }

        public ActionResult New()
        {
            var gender = _context.Genders.ToList();

            var viewModel = new UserFormViewModel
            {
                Gender = gender
            };

            return View("UserForm", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(User user)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new UserFormViewModel
                {
                    User = user,
                    Gender = _context.Genders.ToList()
                };

                return View("UserForm", viewModel);

            }

            _context.Usuarios.Add(user);

            _context.SaveChanges();

            return RedirectToAction("Index", "Users");
        }
    }
}