using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
    public class ShopItem
    {
        [Key]
        public int id { get; set; } 
        public string Name { get; set;}
    }
}
