using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DejavuContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
            Type = '1',
            Period = '0',
            Name = "AddOn $2.99",
            Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 299,
            Comment = "cocommmmmmmmmm",
            Active = '0',
            Swap = '0',
            SearchFr = '0',
            Notifications = '0',
                  Commercial = '0',
                  ImagesNumber = 10,
                  AddOn = '1'
                },
                new Product
                {
            Type = '0',
            Period = '0',
            Name = "AddOn $20",
            Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 2000,
            Comment = "cocommmmmmmmmm",
            Active = '0',
            Swap = '0',
            SearchFr = '0',
            Notifications = '0',
                  Commercial = '1',
                  ImagesNumber = 100,
                  AddOn = '1'
                },
                new Product
                {
            Type = '0',
            Period = '0',
            Name = "AddOn $99",
            Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 9900,
            Comment = "cocommmmmmmmmm",
            Active = '0',
            Swap = '0',
            SearchFr = '0',
            Notifications = '0',
                  Commercial = '1',
                  ImagesNumber = 1000,
                  AddOn = '1'
                },
                new Product
                {
            Type = '0',
            Period = '0',
            Name = "Bronze",
            Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 0,
            Comment = "cocommmmmmmmmm",
            Active = '0',
            Swap = '0',
            SearchFr = '0',
            Notifications = '0',
                  Commercial = '0',
                  ImagesNumber = 5,
                  AddOn = '0'
                },
                new Product
                {
            Type = '0',
            Period = '0',
            Name = "Silver",
            Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 500,
            Comment = "cocommmmmmmmmm",
            Active = '0',
            Swap = '0',
            SearchFr = '0',
            Notifications = '0',
                  Commercial = '0',
                  ImagesNumber = 10,
                  AddOn = '0'
                },
                new Product
                {
            Type = '0',
            Period = '0',
            Name = "Gold",
            Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 900,
            Comment = "cocommmmmmmmmm",
            Active = '0',
            Swap = '1',
            SearchFr = '1',
            Notifications = '1',
                  Commercial = '0',
                  ImagesNumber = 50,
                  AddOn = '0'
                },
                new Product
                {
            Type = '0',
            Period = '0',
            Name = "Platinum",
            Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            Price = 190,
            Comment = "cocommmmmmmmmm",
            Active = '0',
            Swap = '1',
            SearchFr = '2',
            Notifications = '2',
                  Commercial = '0',
                  ImagesNumber = 100,
                  AddOn = '0'
                },
                new Product
                {
                    Type = '0',
                    Period = '0',
                    Name = "Commercial",
                    Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 9900,
                    Comment = "cocommmmmmmmmm",
                    Active = '0',
                    Swap = '1',
                    SearchFr = '2',
                    Notifications = '2',
                    Commercial = '1',
                    ImagesNumber = 1000,
                    AddOn = '0'
                },
                new Product
                {
                    Type = '0',
                    Period = '0',
                    Name = "Commercial+",
                    Desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 99900,
                    Comment = "cocommmmmmmmmm",
                    Active = '0',
                    Swap = '1',
                    SearchFr = '3',
                    Notifications = '2',
                          Commercial = '1',
                          ImagesNumber = 10000,
                          AddOn = '0'
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
