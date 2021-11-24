using System;
using Carthagina.Core.Services;
using Carthagina.Core.Services.Interfaces;
using Carthagina.Database.DbModels;

namespace Carthagina.Core
{
    public class SetupData
    {
        public static void FillDatabase()
        {
            IDataAccess dataAccess = new DatabaseAccessService();

            var customers = new Customer[]
            {
                new()
                {
                    Id = 1,
                    Name = "Tomasz",
                    Surname = "Nowak",
                    PhoneNumber = "123456789"
                },
                new()
                {
                    Id = 2,
                    Name = "Karolina",
                    Surname = "Dziurla",
                    PhoneNumber = "234567890"
                },
                new()
                {
                    Id = 3,
                    Name = "Anna",
                    Surname = "Kowalska",
                    PhoneNumber = "987654321"
                },
                new()
                {
                    Id = 4,
                    Name = "Michal",
                    Surname = "Szczaw",
                    PhoneNumber = "987345098"
                },
                new()
                {
                    Id = 5,
                    Name = "Paulina",
                    Surname = "Sobolewska",
                    PhoneNumber = "651233009"
                },
            };

            var transactions = new Transaction[]
            {
                new()
                {
                    Id = 1,
                    CustomerId = 1,
                    ProductId = 1,
                    OrderDateTime = new DateTime(2021, 1, 12, 7, 16, 12)
                },
                new()
                {
                    Id = 2,
                    CustomerId = 1,
                    ProductId = 1,
                    OrderDateTime = new DateTime(2021, 5, 12, 9, 56, 12)
                },
                new()
                {
                    Id = 3,
                    CustomerId = 2,
                    ProductId = 2,
                    OrderDateTime = new DateTime(2021, 1, 12, 11, 16, 45)
                },
                new()
                {
                    Id = 4,
                    CustomerId = 1,
                    ProductId = 3,
                    OrderDateTime = new DateTime(2021, 12, 12, 17, 16, 12)
                },
                new()
                {
                    Id = 5,
                    CustomerId = 4,
                    ProductId = 2,
                    OrderDateTime = new DateTime(2021, 4, 12, 20, 11, 12)
                },
                new()
                {
                    Id = 6,
                    CustomerId = 5,
                    ProductId = 1,
                    OrderDateTime = new DateTime(2021, 1, 12, 22, 16, 12)
                }
            };

            var products = new Product[]
            {
                new()
                {
                    Id = 1,
                    Name = "Pilka",
                    CategoryId = 1,
                    Price = 19.99
                },
                new()
                {
                    Id = 2,
                    Name = "Rower",
                    CategoryId = 1,
                    Price = 792.99
                },
                new()
                {
                    Id = 3,
                    Name = "Nozyce",
                    CategoryId = 1,
                    Price = 98.29
                },
            };

            var categories = new Category[]
            {
                new()
                {
                    Id = 1,
                    Name = "Sport"
                },
                new()
                {
                    Id = 2,
                    Name = "Narzedzia"
                },
            };

            dataAccess.AddTransactionsRange(transactions);
            dataAccess.AddCategoriesRange(categories);
            dataAccess.AddCustomersRange(customers);
            dataAccess.AddProductsRange(products);
        }
    }
}