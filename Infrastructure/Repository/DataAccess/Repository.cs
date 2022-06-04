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

        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _mainTemplateContext.Set<T>().AddAsync(entity);
            await _mainTemplateContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            _mainTemplateContext.Set<T>().Update(entity);
            await _mainTemplateContext.SaveChangesAsync();
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

        public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _mainTemplateContext.Set<T>().Update(entity);
            await _mainTemplateContext.SaveChangesAsync();
            return entity;
        }
    }
}
