using ApplicationCore.Base.Spesification;
using ApplicationCore.Interface.Base;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Base;

namespace Infrastructure.Repository.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        
        protected readonly MainTemplateContext _mainTemplateContext;

        public Repository(MainTemplateContext mainTemplateContext)
        {
            _mainTemplateContext = mainTemplateContext;
        }

        public Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetItemBySpesification(ISpesification<T> spesification = null)
        {
            return SpesificationEvaluator<T>.GetQuery(_mainTemplateContext.Set<T>().AsQueryable(), spesification);
        }

        public IEnumerable<T> GetAllAsync(ISpesification<T> spesification = null, CancellationToken cancellationToken = default)
        {
            return SpesificationEvaluator<T>.GetQuery(_mainTemplateContext.Set<T>().AsQueryable(), spesification);
        }

        public T GetByIDAsync(ISpesification<T> spesification = null, CancellationToken cancellationToken = default)
        {
            var item = SpesificationEvaluator<T>.GetQuery(_mainTemplateContext.Set<T>().AsQueryable(), spesification).FirstOrDefault();
            return item;
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
