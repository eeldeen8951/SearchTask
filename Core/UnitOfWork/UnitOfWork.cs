using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {

        private readonly SearchTaskContext context;
        public UnitOfWork(SearchTaskContext dbContext)
        {
            this.context = dbContext;
        }
    
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public List<T> FindAll(Expression<Func<T, bool>> match,int take)
        {
            return context.Set<T>().Where(match).Take(take).ToList();
        }
    }
}
