using DAL.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EntityDal
{
    public class ExamDal : IExamDal
    {
        private DataContext db = new DataContext();

        public void Delete(int examId, string Username)
        {
            var kullanici = db.UserModels.FirstOrDefault(w => w.Username == Username);
            int kullaniciId = kullanici.Id;
            var Sınavları = db.Exams.Where(r => r.UserModelId == kullanici.Id);
            var silinecek = Sınavları.FirstOrDefault(w => w.Id == examId);
            db.Remove(silinecek);
            db.SaveChanges();
        }

        public Exam GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Exam> GetListAll()
        {
            return db.Exams.ToList();
        }

        public void Insert(Exam obje)
        {
            db.Exams.Add(obje);
            db.SaveChanges();
        }

        public void Update(Exam obje)
        {
            throw new NotImplementedException();
        }
    }
}