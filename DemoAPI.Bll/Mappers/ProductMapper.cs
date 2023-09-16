using Bll.Entities;
using DalProduct = Dal.Entities.Product;

namespace Bll.Mappers;

public static partial class ProductMapper
{
    internal static Product ToBll(this DalProduct product)
    {
        return new Product(product.Id, product.Name, product.Price);
    }
}