using DAL.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
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

        public async Task Deletex(int examId, string name)  // Düzenli Hali
        {
            var kullanici = db.UserModels.FirstOrDefault(w => w.Username == name);
            int kullaniciId = kullanici.Id;
            var Sınavları = db.Exams.Where(r => r.UserModelId == kullanici.Id);
            var silinecek = Sınavları.FirstOrDefault(w => w.Id == examId);
            db.Remove(silinecek);
            await db.SaveChangesAsync();
        }

        public Task<Exam> GetByIdx(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Exam> GetListAllx() // Düzenlendi
        {
            return db.Exams.AsNoTracking().ToList();
        }

        public async Task Insertx(Exam obje) // düzenlendi
        {
            await db.Exams.AddAsync(obje);
            await db.SaveChangesAsync();
        }

        public void Updatex()
        {
            throw new NotImplementedException();
        }

        public void Updatex(Exam obje)
        {
            throw new NotImplementedException();
        }
    }
}