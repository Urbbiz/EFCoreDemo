using EFCoreDemo.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Dtos
{
    public class ShopItemDto : DtoObject
    {
        public int ShopId { get; set; }

        public decimal Price { get; set; }
    }
}
