using Microsoft.EntityFrameworkCore;
using Task10.Data;
using Task10.Models;

namespace Task10.Services;

public class ProductServiceImpl : IProductService
{
    private readonly AppDbContext _context;

    private readonly ILogger<ProductServiceImpl> _logger;

    public ProductServiceImpl(AppDbContext context, ILogger<ProductServiceImpl> logger)
    {
        _context = context;
        _logger = logger;
    }
    public async Task<List<Product>> GetAllAsync()
    {
        _logger.LogInformation("Fetching all products");
        return await _context.Products.ToListAsync();
    }   

    public async Task<Product?> GetByIdAsync(int id)
    {
        _logger.LogInformation("Fetching product by Id");
        return await _context.Products.FindAsync(id);
    }

    public async Task<Product> CreateAsync(Product product)
    {
        _logger.LogInformation("Creating product");
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product?> UpdateAsync(int id, Product updated)
    {
        _logger.LogInformation("Updating product");
        var product = await _context.Products.FindAsync(id);
        if (product == null) return null;

        product.Name = updated.Name;
        product.Price = updated.Price;

        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        _logger.LogInformation($"Fetching Deleting product with id {id}");
        var product = await _context.Products.FindAsync(id);
        if (product == null) return false;

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return true;
    }
}