using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Base
{
    public interface IReadRepositoryBase<T> where T : class
    {
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<T> GetByIDAsync(string id, CancellationToken cancellationToken = default(CancellationToken));
        Task<T> GetBySpec(string whereclause,string order, CancellationToken cancellationToken = default(CancellationToken));
    }
}
