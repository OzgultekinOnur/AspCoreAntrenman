using BuisnessLayer;
using DAL;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;
using Microsoft.AspNetCore.Http;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private List<TabloDizayn> tablo;
        private UserManager userManager;
        private ExamManager examManager;
        private TextModel wmodel = new TextModel();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult SinavEkrani(IFormCollection datas)
        {
            examManager = new ExamManager();
            int id = int.Parse(datas.Keys.ToList()[0]);
            UsernameTp.SinavId = id;
            var sinav = examManager.SinavListesi().FirstOrDefault(w => w.Id == id);
            wmodel.Sinav = sinav;
            return View(wmodel);
        }

        public IActionResult Sinavlar()
        {
            userManager = new UserManager();

            tablo = new List<TabloDizayn>();
            examManager = new ExamManager();
            wmodel.Sinavlar = examManager.SinavListesi();
            foreach (var item in wmodel.Sinavlar)
            {
                tablo.Add(
                new TabloDizayn
                {
                    SınavId = item.Id,
                    SınavBaslik = item.Text,
                    SınavTarih = item.Date,
                    KullanıcıAdı = userManager.KullaniciAra().FirstOrDefault(r => r.Id == item.UserModelId).Username
                });
            }
            wmodel.tabloDizayns = tablo;
            //Bütün Sınavları Listelendiği sayfa
            return View(wmodel);
        }

        public IActionResult SinavOlustur()
        {
            return View(wmodel);
            //Wired.com Başlıklerını içeren modelim
        }

        public IActionResult Sinavlarim()
        {
            //uyenin adini gönderip sinavlarini çektiğim kısım

            userManager = new UserManager();
            wmodel.Sinavlar = userManager.KullanicininSinavlari(UsernameTp.Username.ToString());
            ViewBag.user = UsernameTp.Username.ToString();
            return View(wmodel);
        }

        public IActionResult Sonuc(string options, string options1, string options2, string options3)
        {
            examManager = new ExamManager();
            var sinav = examManager.SinavListesi().FirstOrDefault(w => w.Id == UsernameTp.SinavId);
            wmodel.Sinav = sinav;
            var yenimodel = UsernameTp.SinavKontrol(options, options1, options2, options3, sinav, wmodel);
            return View("SinavEkrani", yenimodel);
        }

        [HttpPost]
        public IActionResult SinavOlustur(TextModel model)
        {
            int index = wmodel.Basliklar.IndexOf(model.Basliklar[0]);
            model.GeriDonenMetin = model.Metinler[index].ToString();
            UsernameTp.Baslik = model.Basliklar[0];
            UsernameTp.Konu = model.Metinler[index].ToString();
            return View(model);
            //Seçilen Başlığa Uygun Konu Getirdiğim Kısım
        }

        [HttpPost]
        public IActionResult Olustur(TextModel model)
        {
            model.Sinav.Text2 = UsernameTp.Konu;
            model.Sinav.Text = UsernameTp.Baslik;
            model.Sinav.Date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            userManager = new UserManager();
            userManager.KullanıcıyaSınavEkle(UsernameTp.Username.ToString(), model.Sinav);
            return RedirectToAction("Sinavlarim", "Home");
            //DTO ya bağladığım Kısım
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> SinavSil(IFormCollection datas)
        {
            int id = int.Parse(datas.Keys.ToList()[0]);
            examManager = new ExamManager();
            await examManager.SilinecekSınavx(id, UsernameTp.Username);
            return RedirectToAction("Sinavlarim", "Home");
            //Kullanıcının Sınavını Silme isteği
        }
    }
}