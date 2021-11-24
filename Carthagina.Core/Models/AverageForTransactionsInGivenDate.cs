namespace Carthagina.Core.Models
{
    public class AverageForTransactionsInGivenDate
    {
        public double Amount { get; set; }
        public Date Date { get; set; }

        public override string ToString()
            => $"Average for transactions in {Date.ToString()} is {Amount}";
    }
}