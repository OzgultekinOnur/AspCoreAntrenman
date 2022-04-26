using DAL;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class TextModel
    {
        public List<TabloDizayn> tabloDizayns;
        public int DeleteById { get; set; }
        public Exam Sinav { get; set; }
        public List<Exam> Sinavlar { get; set; }
        public string GeriDonenMetin { get; set; }
        public List<string> Basliklar { get; set; }
        public List<string> Metinler { get; set; }
        private Wired wired;

        public TextModel()
        {
            wired = new Wired();
            Baslik();
            Metin();
        }

        private void Baslik()
        {
            Basliklar = wired.SeedTitle();
            //buradan wired.com verilerini çekiyorum
        }

        private void Metin()
        {
            Metinler = wired.SeedText();
            //buradan wired.com verilerini çekiyorum
        }

        public string Sonuclar { get; set; }

        public string Yesil1 { get; set; }
        public string Yesil2 { get; set; }
        public string Yesil3 { get; set; }
        public string Yesil4 { get; set; }
        public string Kirmizi1 { get; set; }
        public string Kirmizi2 { get; set; }
        public string Kirmizi3 { get; set; }
        public string Kirmizi4 { get; set; }
    }
}