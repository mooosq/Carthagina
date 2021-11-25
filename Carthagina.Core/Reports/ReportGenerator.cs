using System;
using System.Linq;
using Carthagina.Core.Configuration.Interfaces;
using Carthagina.Core.Exceptions;
using Carthagina.Core.Models;
using Carthagina.Core.Reports.Interfaces;
using Carthagina.Core.Services.Interfaces;

namespace Carthagina.Core.Reports
{
    public class ReportGenerator : IReportGenerator
    {
        private readonly IDataAccess _dataAccess;

        public ReportGenerator()
        {
            IConfiguration configuration = new Configuration.Configuration();

            try
            {
                _dataAccess = configuration.ConfigureDataSource();
            }
            catch (AccessServiceNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}\nClosing...");
                Environment.Exit(-1);
            }
        }

        public AverageForTransactionsInGivenDate GetDailyTransactionsReport(Date date)
            => new()
            {
                Date = date,
                Amount = _dataAccess.GetProductsByIds(_dataAccess.GetTransactionsByDate(date)
                    .Select(transaction => transaction.ProductId)
                    .ToArray())
                    .Average(product => product.Price)
            };

        public CustomerTransactions GetCustomerTransactions(int customerId)
            => new()
            {
                Customer = _dataAccess.GetCustomerById(customerId),
                Transactions = _dataAccess.GetCustomerTransactions(customerId)
            };

        public DailyProductsReport GetDailyProductReport(int productId, Date date)
            => new()
            {
                Date = date,
                Transactions = _dataAccess
                    .GetTransactionsByProductId(productId)
                    .Where(transaction => transaction.OrderDate.Equals(date)).ToArray(),
                Product = _dataAccess.GetProductsByIds(new[]{productId}).FirstOrDefault()
            };
    }
}