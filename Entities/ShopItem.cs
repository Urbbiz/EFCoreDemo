using EFCoreDemo.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Entities
{
    public class ShopItem : Entity
    {
        public bool Deleted { get; set; } = false;

        public decimal Price { get; set; }

        public Shop? Shop { get; set; }
        public int ShopId { get; set; } = 0;
    }
}
