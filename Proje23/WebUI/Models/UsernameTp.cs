using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public static class UsernameTp
    {
        public static string Username { get; set; }
        public static string Baslik { get; set; }
        public static string Konu { get; set; }
        public static int SinavId { get; set; }

        public static TextModel SinavKontrol(string soru1, string soru2, string soru3, string soru4, Exam exam, TextModel model)
        {
            string cevap1 = "";
            string cevap2 = "";
            string cevap3 = "";
            string cevap4 = "";
            switch (exam.Q1Correct1)
            {
                case "A":
                    cevap1 = "b11";
                    break;

                case "B":
                    cevap1 = "b12";
                    break;

                case "C":
                    cevap1 = "b13";
                    break;

                case "D":
                    cevap1 = "b14";
                    break;

                default:
                    break;
            }
            switch (exam.Q2Correct2)
            {
                case "A":
                    cevap2 = "b21";
                    break;

                case "B":
                    cevap2 = "b22";
                    break;

                case "C":
                    cevap2 = "b23";
                    break;

                case "D":
                    cevap2 = "b24";
                    break;

                default:
                    break;
            }
            switch (exam.Q3Correct3)
            {
                case "A":
                    cevap3 = "b31";
                    break;

                case "B":
                    cevap3 = "b32";
                    break;

                case "C":
                    cevap3 = "b33";
                    break;

                case "D":
                    cevap3 = "b34";
                    break;

                default:
                    break;
            }
            switch (exam.Q4Correct4)
            {
                case "A":
                    cevap4 = "b41";
                    break;

                case "B":
                    cevap4 = "b42";
                    break;

                case "C":
                    cevap4 = "b43";
                    break;

                case "D":
                    cevap4 = "b44";
                    break;

                default:
                    break;
            }

            if (soru1 == cevap1)
                model.Yesil1 = cevap1;
            else
                model.Kirmizi1 = cevap1;

            if (soru2 == cevap2)
                model.Yesil2 = cevap2;
            else
                model.Kirmizi2 = cevap2;

            if (soru3 == cevap3)
                model.Yesil3 = cevap3;
            else
                model.Kirmizi3 = cevap3;

            if (soru4 == cevap4)
                model.Yesil4 = cevap4;
            else
                model.Kirmizi4 = cevap4;
            return model;
        }
    }
}