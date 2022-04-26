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

        public void SinavEkle(Exam sinav)
        {
            try
            {
                exam = new ExamDal();

                exam.Insert(sinav);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Exam> SinavListesi()
        {
            try
            {
                exam = new ExamDal();

                return exam.GetListAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SilinecekSınav(int examId, string Username)
        {
            try
            {
                exam = new ExamDal();
                exam.Delete(examId, Username);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}