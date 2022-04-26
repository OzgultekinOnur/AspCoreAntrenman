using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EntityDal
{
    public class DtoDAL
    {
        private DataContext db = new DataContext();
        private UserModel kullanici;
        private ExamDal exam;

        public void AddExamForUser(string username, Exam sinav)
        {
            //gönderilen isim ve sınavı o isme sahip kullanıcının sınavlarına ekledim
            kullanici = new UserModel();
            kullanici = db.UserModels.FirstOrDefault(x => x.Username == username);
            sinav.UserModelId = kullanici.Id;
            db.Exams.Add(sinav);
            db.SaveChanges();
        }

        public List<Exam> UserSinavlari(string username)
        {
            // kullanıcının ürettiği sınavları o kullanıcının Id sini alarak döndürdüğüm liste
            exam = new ExamDal();

            UserModel kullanici = db.UserModels.FirstOrDefault(x => x.Username == username);
            return exam.GetListAll().Where(y => y.UserModelId == kullanici.Id).ToList();
        }
    }
}