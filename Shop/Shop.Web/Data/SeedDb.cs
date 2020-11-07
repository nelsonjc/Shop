namespace Shop.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using Shop.Web.Helper;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this._context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("nelsonjaramilloc@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirtsName = "Nelson",
                    LastName = "Jaramillo",
                    Email = "nelsonjaramilloc@gmail.com",
                    UserName = "nelsonjaramilloc@gmail.com",
                    PhoneNumber = "3502466644"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if (!this._context.Products.Any())
            {
                this.AddProduct("IPhone XII", user);
                this.AddProduct("Maginc Mouse", user);
                this.AddProduct("IWatch Series 4", user);
                await this._context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            this._context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(1000),
                IsAvailabe = true,
                Stock = this.random.Next(100),
                User = user
            });
        }
    }
}
