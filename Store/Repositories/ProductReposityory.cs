using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductReposityory : RepositoryBase<Product>, IProductRepository
    {
        public ProductReposityory(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FindByCondition(p => p.ProductId.Equals(id),trackChanges);
        }
        
    }
}