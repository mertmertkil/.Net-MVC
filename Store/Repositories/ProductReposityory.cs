using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductReposityory : RepositoryBase<Product>, IProductRepository
    {
        public ProductReposityory(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Product> GetAllProducts(bool trachChanges) => FindAll(trachChanges);

        public Product? GetOneProduct(int id, bool trachChanges)
        {
            return FindByCondition(p => p.ProductId.Equals(id),trachChanges);
        }
        
    }
}