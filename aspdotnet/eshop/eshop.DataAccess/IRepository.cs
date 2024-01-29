using eshop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
    }
}
