using System.Data;
using Dal.Entities;
using Dal.Mappers;
using Dal.Repositories;
using Tools.Database;

namespace Dal.Services;

public class ProductService : IProductRepository
{
    private readonly IDbConnection _dbConnection;

    public ProductService(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<Product> Get()
    {
        return _dbConnection.ExecuteReader("Select Id, Name, Price FROM Product", dr => dr.ToProduct());
    }

    public Product? Get(int id)
    {
        return _dbConnection.ExecuteReader("Select Id, Name, Price FROM Product WHERE Id = @Id", dr => dr.ToProduct(),
            parameters: new { Id = id }).SingleOrDefault();
    }

    public Product Insert(Product product)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product product)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}