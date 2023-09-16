using System.Data;
using Dal.Entities;

namespace Dal.Mappers;

internal static class ProductMapper
{
    internal static Product ToProduct(this IDataRecord dataRecord)
    {
        return new Product
        {
            Id = (int)dataRecord["Id"],
            Name = (string)dataRecord["Name"],
            Price = (decimal)dataRecord["Price"]
        };
    }
}