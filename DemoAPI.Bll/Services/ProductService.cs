using Bll.Entities;
using Bll.Mappers;
using Bll.Repositories;

namespace Bll.Services;

public class ProductService : IProductRepository
{
    private readonly Dal.Repositories.IProductRepository _productRepositoryDal;

    public ProductService(Dal.Repositories.IProductRepository repository)
    {
        _productRepositoryDal = repository;
    }

    public IEnumerable<Product> Get()
    {
        return _productRepositoryDal.Get().Select(p => p.ToBll());
    }

    public Product? Get(int id)
    {
        return _productRepositoryDal.Get(id)?.ToBll();
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