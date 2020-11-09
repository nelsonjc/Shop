namespace Shop.Web.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity;
    using Shop.Web.Helper;
    using System;
    using System.Collections.Generic;
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

            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Custumer");

            if (!_context.Countries.Any())
            {
                var cities = new List<City>
                {
                    new City { Name = "Medellín" },
                    new City { Name = "Bogotá" },
                    new City { Name = "Calí" }
                };

                _context.Countries.Add(new Country
                {
                    Cities = cities,
                    Name = "Colombia"
                });

                await _context.SaveChangesAsync();
            }

            var user = await _userHelper.GetUserByEmailAsync("nelsonjaramilloc@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Nelson",
                    LastName = "Jaramillo",
                    Email = "nelsonjaramilloc@gmail.com",
                    UserName = "nelsonjaramilloc@gmail.com",
                    PhoneNumber = "3502466644",
                    Address = "Calle Luna Calle Sol",
                    CityId = _context.Countries.FirstOrDefault().Cities.FirstOrDefault().Id,
                    City = _context.Countries.FirstOrDefault().Cities.FirstOrDefault()
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                    throw new InvalidOperationException("Could not create the user in seeder");

                await _userHelper.AddUserToroleAsync(user, "Admin");
            }

            var isInRol = await _userHelper.IsUserInRoleAsync(user, "Admin");

            if (!isInRol)
                await _userHelper.AddUserToroleAsync(user, "Admin");


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
