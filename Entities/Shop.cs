using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Entities
{
    public class Shop
    {
        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
    }
}
