using AutoMapper;
using EFCoreDemo.Controllers.Base;
using EFCoreDemo.Data;
using EFCoreDemo.Dtos;
using EFCoreDemo.Entities;
using EFCoreDemo.Repositories;
using EFCoreDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : GenericControllerBase<ShopItemDto, ShopItem>
    {
        private IMapper _mapper;
        private GenericRepository<ShopItem> _repository;
        private PriceCalculationService _priceCalculationService;

        public ShopItemController(IMapper mapper, GenericRepository<ShopItem> repository, PriceCalculationService priceCalculationService) : base(mapper, repository)
        {
            _mapper = mapper;
            _repository = repository;
            _priceCalculationService = priceCalculationService;
        }

        [HttpGet]
        public async override Task<List<ShopItemDto>> GetAll()
        {
            var enteties = await _repository.GetAll();

            var dtos = _mapper.Map<List<ShopItemDto>>(enteties);

            var updatedDtos = dtos.Select(d => _priceCalculationService.ApplyDiscount(d));
            

            return dtos;
  
        }

    }
}
