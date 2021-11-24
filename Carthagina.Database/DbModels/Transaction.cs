using System;
using System.ComponentModel.DataAnnotations;

namespace Carthagina.Database.DbModels
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}