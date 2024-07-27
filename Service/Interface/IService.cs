using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.Interface
{
    public interface IService<T> where T : class
    {
        public Task Add(T service);
        public Task Update(int id,T service);
        public Task Delete(int id);
        public Task<T> GetById(int id);
        public Task<List<T>> GetAll();
    }
}
