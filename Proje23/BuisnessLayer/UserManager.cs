using DAL.Concrete.EntityDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class UserManager
    {
        private UserModelDal user = new UserModelDal();
        private DtoDAL dto = new DtoDAL();

        public async Task KullaniciEklex(UserModel kullanici)
        {
            try
            {
                if (kullanici.Username == "" || kullanici.Password == "")
                {
                }
                else
                {
                    await user.Insertx(kullanici);
                }
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public List<UserModel> KullaniciAra()
        {
            try
            {
                return user.GetListAllx();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //-- Kullanıcının İlişkisel Bağlantıları
        public async Task KullanıcıyaSınavEkle(string username, Exam sinav)
        {
            try
            {
                //DtoDAL dto = new DtoDAL();
                await dto.AddExamForUserx(username, sinav);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Exam> KullanicininSinavlari(string username)
        {
            try
            {
                //DtoDAL dto = new DtoDAL();
                return dto.UserSinavlarix(username);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void KullaniciGuncelle()
        {
            try
            {
                user.Updatex();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}