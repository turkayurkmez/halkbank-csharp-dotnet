using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public interface IEntity
    {

    }
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Customer : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }

    }

    public interface IRepository<T> where T : IEntity, new()
    {
        int Create(T entity);
        IEnumerable<T> GetAll();
        T Get(int id);
        void Update(T entity);


    }

    public class ProductRepository : IRepository<Product>
    {
        public int Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
