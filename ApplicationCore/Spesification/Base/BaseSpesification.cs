using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Base.Spesification
{
    public class BaseSpesification<T> : ISpesification<T>
    {
        public BaseSpesification()
        {

        }
        public BaseSpesification(Expression<Func<T,bool>> criteria)
        {
            Criteria = criteria;
        }
        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T,object>>>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        public Expression<Func<T, object>> GroupBy { get; private set; }

        protected void AddInclude(Expression<Func<T,object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected void AddOrderBy(Expression<Func<T,object>> orderByExpression)
        {
            OrderBy = (orderByExpression);
        }
        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OrderByDescending = (orderByDescExpression);
        }
        protected void AddGroupBy(Expression<Func<T, object>> groupByDescExpression)
        {
            GroupBy = (groupByDescExpression);
        }
    }
}
