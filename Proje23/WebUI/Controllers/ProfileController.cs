using BuisnessLayer;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ProfileController : Controller
    {
        private UserManager userManager = new UserManager();

        public IActionResult Index()
        {
            var user = userManager.KullaniciAra().FirstOrDefault(w => w.Username == HttpContext.Session.GetString("uye").ToString());
            return View(user);
        }
    }
}