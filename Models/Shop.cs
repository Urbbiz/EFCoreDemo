using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models
{
    public class Shop
    {
        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
    }
}
