using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trachChanges);
        Product? GetOneProduct(int id, bool trachChanges);
    }
}