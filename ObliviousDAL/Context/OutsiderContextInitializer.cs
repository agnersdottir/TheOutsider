using ObliviousDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.Context
{
   public class OutsiderContextInitializer : DropCreateDatabaseAlways<OutsiderContext>
    {
        protected override void Seed(OutsiderContext context)
        {
            IList<Product> products = new List<Product>();

            Category cat1 = context.Categories.Add(new Category() { Id = 1, Name = "Shampoo" });
            Category cat2 = context.Categories.Add(new Category() { Id = 2, Name = "Conditioner" });
            Category cat3 = context.Categories.Add(new Category() { Id = 3, Name = "Wax" });

            Brand brand1 = context.Brands.Add(new Brand() { Id = 1, Name = "Vision Haircare" });
            Brand brand2 = context.Brands.Add(new Brand() { Id = 2, Name = "Doop" });

            //Customer customer1 = context.Customers.Add(new Customer() { Id = 1, Name = "Unagi", Email = "Google@google.tinfoil", Password = "1234abcd" });

            products.Add(new Product()
            {
                Name = "It´s Silver",
                Ml = 200,
                ProductDescription = "About It´s Silver",
                PictureUrl = "Silver Picture here!",
                VideoUrl = "How to Url here!",
                Price = 120,
                Quantity = 1,
                Rating = 5,
                Categories = new List<Category>() { cat1},
                Brands = new List<Brand>() { brand1}
            });
            products.Add(new Product()
            {
                Name = "Thicker",
                Ml = 500,
                ProductDescription = "About Thicker",
                PictureUrl = "Thicker Picture here!",
                VideoUrl = "How to Url here!",
                Price = 100,
                Quantity = 2,
                Rating = 5,
                Categories = new List<Category>() { cat3 },
                Brands = new List<Brand>() { brand1 }
            });
            products.Add(new Product()
            {
                Name = "The Gangster",
                Ml = 200,
                ProductDescription = "About Gangster",
                PictureUrl = "Gangster Picture here!",
                VideoUrl = "How to Url here!",
                Price = 90,
                Quantity = 3,
                Rating = 4,
                Categories = new List<Category>() { cat3 },
                Brands = new List<Brand>() { brand2 }
            });
            products.Add(new Product()
            {
                Name = "Hair Food",
                Ml = 700,
                ProductDescription = "About Hair food",
                PictureUrl = "Hair food Picture here!",
                VideoUrl = "How to Url here!",
                Price = 250,
                Quantity = 1,
                Rating = 4,
                Categories = new List<Category>() { cat2 },
                Brands = new List<Brand>() { brand1 }
            });
           
        }
    }
}
