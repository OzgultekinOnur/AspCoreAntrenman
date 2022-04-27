using BuisnessLayer;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        private UserManager usermanager = new UserManager();

        [HttpPost]
        public IActionResult UserLogin(UserModel user)
        {
            var Anyuser = usermanager.KullaniciAra().FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (Anyuser != null)
            {
                HttpContext.Session.SetString("uye", Anyuser.Username);
                UsernameTp.Username = HttpContext.Session.GetString("uye").ToString();
                return RedirectToAction("Sinavlar", "Home");
            }
            else
            {
                ViewBag.message = "Böyle Bir Kullanıcı Yoktur.";
                return View();
            }
        }

        public IActionResult UserSignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserSignUp(UserModel user)
        {
            var Anyuser = usermanager.KullaniciAra().FirstOrDefault(x => x.Username == user.Username);
            if (Anyuser != null)
            {
                ViewBag.message = "Bu Kullanıcı Adı Zaten Mevcut";
                return View();
            }
            else
            {
                usermanager.KullaniciEkle(user);
                ViewBag.message = "Kayıt Oluşturuldu";
                return View();
            }
        }

        public IActionResult Quit()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "NewLogin");
        }
    }
}