namespace Shop.Web.Data
{
    using Shop.Web.Data.Entities;
    using System.Linq;

    public interface IProductsRepository: IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }
}
