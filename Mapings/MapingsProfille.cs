using AutoMapper;
using EFCoreDemo.Dtos;
using EFCoreDemo.Entities;

namespace EFCoreDemo.Mapings
{
    public class MapingsProfille : Profile
    {
        public MapingsProfille()
        {
            CreateMap<ShopItemDto, ShopItem>().ReverseMap();
            CreateMap<ShopDto, Shop>().ReverseMap();
        }
    }
}
