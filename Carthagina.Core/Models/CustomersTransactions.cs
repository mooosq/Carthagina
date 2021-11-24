using Carthagina.Database.DbModels;

namespace Carthagina.Core.Models
{
    public class CustomerTransactions
    {
        public Customer Customer { get; set; }
        public Transaction[] Transactions { get; set; }
    }
}