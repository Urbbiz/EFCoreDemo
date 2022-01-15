using EFCoreDemo.Dtos;

namespace EFCoreDemo.Services
{
    public class PriceCalculationService
    {
        private readonly DiscountService _discountService;

        public PriceCalculationService(DiscountService discountService)
        {
            _discountService = discountService;
        }

        public ShopItemDto ApplyDiscount(ShopItemDto item)
        {
            if (item.Price != 0)
            {
                item.Price = item.Price - _discountService.CalculateDiscount(item.Price);
            }
            return item;
        }
    }
}
