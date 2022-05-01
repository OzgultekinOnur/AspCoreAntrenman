using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        public Task Insertx(T obje);

        public Task Deletex(int Id, string name);

        public void Updatex(T obje);

        public List<T> GetListAllx();

        public Task<T> GetByIdx(int Id);
    }
}