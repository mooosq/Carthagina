using System.ComponentModel.DataAnnotations;

namespace Carthagina.Database.DbModels
{
    public class Product
    {
        [Key]
        public int Id { get; init; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}