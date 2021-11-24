namespace Carthagina.Core.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public Date OrderDate { get; set; }
    }
}