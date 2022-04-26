using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T obje);

        void Delete(int Id, string name);

        void Update(T obje);

        List<T> GetListAll();

        T GetByID(int id);
    }
}