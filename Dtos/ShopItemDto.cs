using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Dtos
{
    public class ShopItemDto
    {
        [MaxLength(50)]
        public string? Name { get; set; }
        public int ShopId { get; set; }
    }
}
