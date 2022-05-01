using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddExamForUserx(string username, Exam sinav)
        {
            //gönderilen isim ve sınavı o isme sahip kullanıcının sınavlarına ekledim
            kullanici = new UserModel();
            kullanici = db.UserModels.AsNoTracking().FirstOrDefault(x => x.Username == username);
            sinav.UserModelId = kullanici.Id;
            await db.Exams.AddAsync(sinav);
            await db.SaveChangesAsync();
        }

        public List<Exam> UserSinavlarix(string username)
        {
            // kullanıcının ürettiği sınavları o kullanıcının Id sini alarak döndürdüğüm liste
            exam = new ExamDal();
            UserModel kullanici = db.UserModels.AsNoTracking().FirstOrDefault(x => x.Username == username);
            return exam.GetListAllx().Where(y => y.UserModelId == kullanici.Id).ToList();
        }
    }
}