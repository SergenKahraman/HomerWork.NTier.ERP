using HomeWork.NTier.ERP.Data.Access;
using HomeWork.NTier.ERP.Data.Entities;
using HomeWork.NTier.ERP.Dto.Products;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.NTier.ERP.Service.Products
{
    public class ProductListService
    {
        private readonly Repository<Product> repo;

        public ProductListService()
        {
            repo = new Repository<Product>();
        }

        public IEnumerable<ProductListDto> GetAllProducts()
        {
            var query = repo.Select(s => new ProductListDto
            {
                Id = s.Id,
                Name = s.ProductName,
                Price = s.UnitPrice,
                Stock = s.UnitsInStock
            });
            return query.ToList();
        }

        public IEnumerable<ProductListDto> GetPagedProducts(int pageIndex, int limit)
        {
            var query = repo.Select(s => new ProductListDto
            {
                Id = s.Id,
                Name = s.ProductName,
                Price = s.UnitPrice,
                Stock = s.UnitsInStock
            })
            .OrderBy(p => p.Name)
            .Skip(pageIndex * limit)
            .Take(limit);
            return query.ToList();
        }
    }
}