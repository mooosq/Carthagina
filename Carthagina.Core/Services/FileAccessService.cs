using System.Threading.Tasks;
using Carthagina.Core.Models;
using Carthagina.Core.Services.Interfaces;
using Carthagina.Database.DbModels;

namespace Carthagina.Core.Services
{
    public class FileAccessService : IDataAccess
    {
        public Task AddCustomersRange(Customer[] customers)
        {
            throw new System.NotImplementedException();
        }

        public Task AddProductsRange(Product[] products)
        {
            throw new System.NotImplementedException();
        }

        public Task AddCategoriesRange(Category[] categories)
        {
            throw new System.NotImplementedException();
        }

        public Task AddTransactionsRange(Transaction[] transactions)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetProductsByIds(int[] productsIds)
        {
            throw new System.NotImplementedException();
        }

        public Transaction[] GetCustomerTransactions(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public Customer[] GetAllCustomers()
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Category[] GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public Transaction[] GetAllTransactions()
        {
            throw new System.NotImplementedException();
        }

        public Transaction[] GetTransactionsByDate(Date date)
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new System.NotImplementedException();
        }

        public TransactionModel[] GetTransactionsByProductId(int productId)
        {
            throw new System.NotImplementedException();
        }
    }
}