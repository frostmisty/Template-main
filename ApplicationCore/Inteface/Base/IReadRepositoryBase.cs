using ApplicationCore.Base.Spesification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interface.Base
{
    public interface IReadRepositoryBase<T> where T : class
    {
        IEnumerable<T> GetAllAsync(ISpesification<T> spesification = null, CancellationToken cancellationToken = default(CancellationToken));
        T GetByIDAsync(ISpesification<T> spesification = null, CancellationToken cancellationToken = default(CancellationToken));
        IEnumerable<T> GetItemBySpesification(ISpesification<T> spesification = null);
    }
}
