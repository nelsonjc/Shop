
namespace Shop.Web.Data
{
    using Entities;

    public class ProductsRepository: GenericRepository<Product>, IProductsRepository
    {
        public ProductsRepository(DataContext context): base(context)
        {

        }
    }
}
