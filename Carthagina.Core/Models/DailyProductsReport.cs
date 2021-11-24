using Carthagina.Database.DbModels;

namespace Carthagina.Core.Models
{
    public class DailyProductsReport
    {
        public Date Date { get; set; }
        public Product Product { get; set; }
        public TransactionModel[] Transactions { get; set; }
    }
}