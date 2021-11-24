using Carthagina.Core.Reports;
using Xunit;

namespace Carthagina.Core.Tests.Services
{
    public class DatabaseAccessServicesTests
    {
        [Fact]
        public void ReportGenerator_ClientWithId2_HasOneTransactionWithProductId1()
        {
            SetupData.FillDatabase();

            var reportGenerator = new ReportGenerator();

            var customerTransactions = reportGenerator.GetCustomerTransactions(2);

            Assert.Equal(1, customerTransactions.Transactions[0].ProductId);
        }
    }
}