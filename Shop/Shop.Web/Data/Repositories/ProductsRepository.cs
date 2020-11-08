
namespace Shop.Web.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class ProductsRepository: GenericRepository<Product>, IProductsRepository
    {
        private readonly DataContext context;

        public ProductsRepository(DataContext context): base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return this.context.Products.Include(p => p.User); 
        }
    }
}
