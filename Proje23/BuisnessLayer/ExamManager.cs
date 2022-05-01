using DAL.Concrete.EntityDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class ExamManager
    {
        private ExamDal exam;

        public async Task SinavEklex(Exam sinav) // düzenli
        {
            try
            {
                exam = new ExamDal();
                await exam.Insertx(sinav);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Exam> SinavListesi() // Düzenlendi
        {
            try
            {
                exam = new ExamDal();

                return exam.GetListAllx();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task SilinecekSınavx(int examId, string name) //düzenlendi
        {
            try
            {
                exam = new ExamDal();
                await exam.Deletex(examId, name);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}