using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    /*
     * Bir nesne; sadece ihtiyacı olduğu fonksiyonları implemente etmelidir.
     */
    public interface IRepository
    {
        void Create();
        void Update();

        void Delete();
        List<object> GetAll();
        object GetById(int id);

     
    }

    public interface IProductRepository: IRepository
    {
        List<object> GetByName(string name);
    }

    public class ProductRepository : IProductRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class OrderRepository : IRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

       

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
