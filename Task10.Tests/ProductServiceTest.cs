using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Task10.Data;
using Task10.Models;
using Task10.Services;

public class ProductServiceTests
{
    private AppDbContext GetDbContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

        return new AppDbContext(options);
    }

    [Fact]
    public async Task CreateProduct_ShouldAddProduct()
    {   

        Console.Write("Testing create product");
        var context = GetDbContext();

        var loggerMock = new Mock<ILogger<ProductServiceImpl>>();

        var service = new ProductServiceImpl(context, loggerMock.Object);

        var product = new Product { Name = "Test", Price = 100 };

        var result = await service.CreateAsync(product);

        Assert.NotNull(result);
        Assert.Equal("Test", result.Name);
    }
}