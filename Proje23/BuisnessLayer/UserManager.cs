﻿using DAL.Concrete.EntityDal;
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
        public void KullaniciEkle(UserModel kullanici)
        {
            try
            {
                if (kullanici.Username == "" || kullanici.Password == "")
                {
                }
                else
                {
                    UserModelDal user = new UserModelDal();
                    user.Insert(kullanici);
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
                UserModelDal user = new UserModelDal();
                return user.GetListAll();
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
                DtoDAL dto = new DtoDAL();
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
                DtoDAL dto = new DtoDAL();
                return dto.UserSinavlari(username);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}