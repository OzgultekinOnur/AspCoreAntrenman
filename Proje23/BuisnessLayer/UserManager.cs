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
        public void KullanıcıyaSınavEkle(string username, Exam sinav)
        {
            try
            {
                //DtoDAL dto = new DtoDAL();
                dto.AddExamForUser(username, sinav);
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
                return dto.UserSinavlari(username);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task KullaniciGuncelle()
        {
            try
            {
                await user.Updatex();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}