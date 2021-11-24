using System.Threading.Tasks;
using Carthagina.Core.Models;
using Carthagina.Database.DbModels;

namespace Carthagina.Core.Services.Interfaces
{
    public interface IDataAccess
    {
        Task AddCustomersRange(Customer[] customers);
        Task AddProductsRange(Product[] products);
        Task AddCategoriesRange(Category[] categories);
        Task AddTransactionsRange(Transaction[] transactions);
        
        Product[] GetProductsByIds(int[] productsIds);
        Transaction[] GetCustomerTransactions(int customerId);
        Customer[] GetAllCustomers();
        Product[] GetAllProducts();
        Category[] GetAllCategories();
        Transaction[] GetAllTransactions();
        Transaction[] GetTransactionsByDate(Date date);
        
        Customer GetCustomerById(int id);
        TransactionModel[] GetTransactionsByProductId(int productId);
    }
}