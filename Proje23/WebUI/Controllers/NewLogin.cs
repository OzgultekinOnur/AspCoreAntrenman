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
    public class NewLogin : Controller
    {
        private UserManager usermanager = new UserManager();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserModel user)
        {
            var Anyuser = usermanager.KullaniciAra().FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (Anyuser != null)
            {
                if (Anyuser.Active)
                {
                    HttpContext.Session.SetString("uye", Anyuser.Username);
                    UsernameTp.Username = HttpContext.Session.GetString("uye").ToString();
                    return RedirectToAction("Sinavlar", "Home");
                }
                else
                {
                    HttpContext.Session.SetString("uye", Anyuser.Username);
                    return View("Index2", user);
                }
            }
            else
            {
                ViewBag.LoginMessage = "Password or username is incorrect";
                return View();
            }
        }

        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index1(UserModel user)
        {
            if (UserInformation(user))
            {
                var Anyuser = usermanager.KullaniciAra().FirstOrDefault(x => x.Username == user.Username || x.Email == user.Email);
                if (Anyuser == null)
                {
                    user.Active = false;
                    user.ActivationCode = SendMail(user.Email);
                    await usermanager.KullaniciEklex(user);
                    HttpContext.Session.SetString("uye", user.Username);

                    return View("Index2");
                }
                else
                {
                    ViewBag.message = "Username or e-mail address unavailable";
                    return View();
                }
            }
            else
                return View();
        }

        [HttpPost]
        public IActionResult Index2(UserModel user)
        {
            var usertest = usermanager.KullaniciAra().FirstOrDefault(w => w.Username == HttpContext.Session.GetString("uye").ToString());
            if (user.ActivationCode.Trim() == usertest.ActivationCode.Trim())
            {
                usertest.Active = true;
                usermanager.KullaniciGuncelle(usertest);
                return View("Congrats");
            }
            else
            {
                ViewBag.message = "That is Wrong Code ! ";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult ActivationCodeSend(UserModel user)
        {
            var usertest = usermanager.KullaniciAra().FirstOrDefault(w => w.Username == HttpContext.Session.GetString("uye").ToString());
            usertest.ActivationCode = SendMail(usertest.Email);
            usermanager.KullaniciGuncelle(usertest);
            ViewBag.ActivCodeSended = "Your new Activation code has been sent to your e-mail address.";
            return RedirectToAction("Index2", "NewLogin");
        }

        public IActionResult Quit()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "NewLogin");
            //Kullanıcının Sınavını Silme isteği
        }

        public IActionResult Congrats()
        {
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

        public string SendMail(string kime)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randommessage = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("messagebykonogr@outlook.com", "so211297");
            istemci.Port = 587;
            istemci.Host = "smtp-mail.outlook.com";
            istemci.EnableSsl = true;
            //mesajım.Attachments.Add(new Attachment(@"C:\deneme-upload.jpg"));
            mesajım.To.Add(kime);
            mesajım.From = new MailAddress("messagebykonogr@outlook.com");
            mesajım.Subject = "Activation Code";
            mesajım.Body = "Activation Code: " + randommessage;
            istemci.Send(mesajım);
            return randommessage;
        }

        #endregion UserInfControl
    }
}