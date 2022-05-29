using Infrastructure.Context;
using Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Data
{
    public class MainTemplateRepository<T> : IRepository<T> where T : class
    {
        
        protected readonly MainTemplateContext _mainTemplateContext;

        public MainTemplateRepository(MainTemplateContext mainTemplateContext)
        {
            _mainTemplateContext = mainTemplateContext;
        }

        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _mainTemplateContext.AddAsync(entity, cancellationToken);
            await _mainTemplateContext.SaveChangesAsync();
            return entity;
        }

        public Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _mainTemplateContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIDAsync(string id, CancellationToken cancellationToken = default)
        {
            return await _mainTemplateContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetBySpec(string whereclause, string order, CancellationToken cancellationToken)
        {
            var dynamicResult = await _mainTemplateContext.Set<T>().FindAsync(whereclause, order, cancellationToken);
            return dynamicResult;
        }
    }
}
