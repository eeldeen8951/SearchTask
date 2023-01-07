using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        public List<T> FindAll(Expression<Func<T, bool>> match, int take);
        List<T> GetAll();
    }
}
