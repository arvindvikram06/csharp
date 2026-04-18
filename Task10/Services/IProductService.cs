using Task10.Models;

namespace Task10.Services;

public interface IProductService
{
    Task<List<Product>> GetAllAsync();

    Task<Product?> GetByIdAsync(int id);

    Task<Product> CreateAsync(Product product);

    Task<Product?> UpdateAsync(int id, Product product);

    Task<bool> DeleteAsync(int id);
}