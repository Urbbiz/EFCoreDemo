using AutoMapper;
using EFCoreDemo.Data;
using EFCoreDemo.Dtos;
using EFCoreDemo.Entities;
using EFCoreDemo.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly GenericRepository<ShopItem> _repository;

        public ShopItemController(DataContext context, IMapper mapper, GenericRepository<ShopItem> repository)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]   
        public async Task<List<ShopItemDto>> GetAll()
        {
            var enteties = await _context.ShopItems.ToListAsync();
            var dto = _mapper.Map<List<ShopItemDto>>(enteties);
            return dto;
       
        }

        public ShopItemDto GetShop(int id)
        {
            //  return _context.Shops.FirstOrDefault(s => s.id == id);
            var entity = _repository.FinidById(id);

            return _mapper.Map<ShopItemDto>(entity);
        }


        [HttpPost]
        public async Task Post(ShopItemDto item)
        {
            var entity = _mapper.Map<ShopItem>(item);

            _context.ShopItems.Add(entity);

            _context.SaveChangesAsync();
        }
    }
}
