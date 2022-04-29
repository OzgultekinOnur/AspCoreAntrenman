using DAL.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EntityDal
{
    public class UserModelDal : IUserModelDal
    {
        private DataContext db = new DataContext();

        public void Delete(int Id, string name)
        {
        }

        public UserModel GetByID(int id)
        {
            var model = db.UserModels.Where(r => r.Id == id);
            return (UserModel)model;
        }

        public List<UserModel> GetListAll()
        {
            return db.UserModels.ToList();
        }

        public void Insert(UserModel obje)
        {
            db.UserModels.Add(obje);
            db.SaveChanges();
        }

        public void Update()
        {
            db.SaveChanges();
        }
    }
}