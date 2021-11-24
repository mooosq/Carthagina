using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Carthagina.Core.Models;
using Carthagina.Core.Services.Interfaces;
using Carthagina.Database.DbContexts;
using Carthagina.Database.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Carthagina.Core.Services
{
    public class DatabaseAccessService : IDataAccess
    {
        private readonly CarthaginaContext _carthaginaContext;
        private readonly IMapper _mapper;

        public DatabaseAccessService()
        {
            var options = new DbContextOptionsBuilder<CarthaginaContext>()
                .UseInMemoryDatabase("carthagina")
                .Options;
            
            var config = new MapperConfiguration(config => {
                config.AddMaps(Assembly.GetExecutingAssembly());
            });

            _mapper = new Mapper(config);

            _carthaginaContext = new CarthaginaContext(options);
        }

        public async Task AddCustomersRange(Customer[] customers)
        {
            _carthaginaContext.Set<Customer>().AddRange(customers);
            
            await _carthaginaContext.SaveChangesAsync();
        }

        public async Task AddCategoriesRange(Category[] categories)
        {
            _carthaginaContext.Set<Category>().AddRange(categories);
            
            await _carthaginaContext.SaveChangesAsync();
        }

        public async Task AddTransactionsRange(Transaction[] transactions)
        {
            _carthaginaContext.Set<Transaction>().AddRange(transactions);

            await _carthaginaContext.SaveChangesAsync();
        }

        public async Task AddProductsRange(Product[] products)
        {
            _carthaginaContext.Set<Product>().AddRange(products);

            await _carthaginaContext.SaveChangesAsync();
        }

        public Customer[] GetAllCustomers()
            => _carthaginaContext.Set<Customer>()
                .ToArray();

        public Product[] GetAllProducts()
            => _carthaginaContext.Set<Product>()
                .ToArray();

        public Category[] GetAllCategories()
            => _carthaginaContext.Set<Category>()
                .ToArray();

        public Transaction[] GetAllTransactions()
            => _carthaginaContext.Set<Transaction>()
                .ToArray();

        public Customer GetCustomerById(int id)
            => _carthaginaContext.Set<Customer>()
                .FirstOrDefault(customer => customer.Id == id);

        public Product[] GetProductsByIds(int[] productsIds)
            => _carthaginaContext.Set<Product>()
                .Where(product => productsIds.Contains(product.Id))
                .ToArray();

        public Transaction[] GetTransactionsByDate(Date date)
            => _carthaginaContext.Set<Transaction>()
                .Where(transaction => date.Equals(transaction.OrderDateTime))
                .ToArray();

        public Transaction[] GetCustomerTransactions(int customerId)
            => _carthaginaContext.Set<Transaction>()
                .Where(transaction => transaction.CustomerId == customerId)
                .ToArray();

        public TransactionModel[] GetTransactionsByProductId(int productId)
            => _carthaginaContext.Set<Transaction>()
                .Where(transaction => transaction.ProductId == productId)
                .ProjectTo<TransactionModel>(_mapper.ConfigurationProvider)
                .ToArray();
    }
}