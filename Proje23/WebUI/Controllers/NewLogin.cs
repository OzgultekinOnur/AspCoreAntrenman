using BuisnessLayer;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class NewLogin : Controller
    {
        private UserManager usermanager = new UserManager();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index1(UserModel user)
        {
            if (UserInformation(user))
            {
                var Anyuser = usermanager.KullaniciAra().FirstOrDefault(x => x.Username == user.Username || x.Email == user.Email);
                if (Anyuser != null)
                {
                    ViewBag.message = "Username or e-mail address unavailable";
                    return View();
                }
                else
                {
                    usermanager.KullaniciEkle(user);
                    ViewBag.message = "Registration Successful";
                    return View();
                }
            }
            else
                return View();
        }

        #region UserInfControl

        public bool PwControl(UserModel usercontrol)
        {
            if (usercontrol.Password.Length > 6)
            {
                ViewBag.password = "Valid";
                return true;
            }
            else
            {
                ViewBag.password = "Password must be at least 6 digits";
                return false;
            }
        }

        public bool UnControl(UserModel usercontrol)
        {
            if (usercontrol.Username.Length > 5)
            {
                ViewBag.username = "Valid";
                return true;
            }
            else
            {
                ViewBag.username = "Username must be at least 5 characters";
                return false;
            }
        }

        public bool EmailControl(UserModel usercontrol)
        {
            if (usercontrol.Email.Contains("@") && usercontrol.Email.Length > 12)
            {
                ViewBag.email = "Valid";
                return true;
            }
            else
            {
                ViewBag.email = "Invalid Email";
                return false;
            }
        }

        public bool UserInformation(UserModel usercontrol)
        {
            if (EmailControl(usercontrol) && UnControl(usercontrol) && PwControl(usercontrol))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion UserInfControl
    }
}