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
    public class UserModelDal : IUserModelDal
    {
        private DataContext db = new DataContext();

        public Task Deletex(int Id, string name)
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> GetByIdx(int Id)
        {
            return await db.UserModels.AsNoTracking().FirstOrDefaultAsync(r => r.Id == Id);
        }

        public List<UserModel> GetListAllx() //Düzenlendi
        {
            return db.UserModels.AsNoTracking().ToList();
        }

        public async Task Insertx(UserModel obje) // düzenlendi
        {
            await db.UserModels.AddAsync(obje);
            await db.SaveChangesAsync();
        }

        public void Updatex(UserModel obje) //Düzenlendi
        {
            db.Update(obje);
            db.SaveChanges();
        }
    }
}