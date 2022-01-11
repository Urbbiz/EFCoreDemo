using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Entities
{
    public class ShopItem
    {
        [Key]
        public int id { get; set; }
        
        [MaxLength(50)]
        public string? Name { get; set;}

        public bool Deleted { get; set; } = false;

        public Shop? Shop { get; set; }
        public int ShopId { get; set; }
    }
}
