using AutoMapper;
using EFCoreDemo.Data;
using EFCoreDemo.Dtos;
using EFCoreDemo.Entities;
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

        public ShopItemController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]   
        public List<ShopItemDto> GetAll()
        {
            var enteties = _context.ShopItems.ToList();
            var dto = _mapper.Map<List<ShopItemDto>>(enteties);
            return dto;
       
        }

        
        [HttpPost]
        public void Post(ShopItemDto item)
        {
            var entity = _mapper.Map<ShopItem>(item);
            _context.ShopItems.Add(entity);
            _context.SaveChanges();
        }
    }
}
