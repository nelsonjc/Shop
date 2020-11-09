namespace Shop.Web.Controllers.API
{
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Data;

    [Route("api/[Controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductsController: Controller
    {
        private readonly IProductRepository _productsRepository;

        public ProductsController(IProductRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productsRepository.GetAllWithUsers());
        }
    }
}
