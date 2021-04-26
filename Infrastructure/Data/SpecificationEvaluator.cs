using System.Linq;
using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity :BaseEntity
    {
        public static IQueryable <TEntity> GetQuary(IQueryable<TEntity> inputQuery, ISpecification <TEntity> spec)
        {
            var query = inputQuery;

            if ( spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);// for example for Criteria p => p.ProductType == id
            }
            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
        return query;
        }
    }
}