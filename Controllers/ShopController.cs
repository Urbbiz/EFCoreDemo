using AutoMapper;
using EFCoreDemo.Data;
using EFCoreDemo.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;


        public ShopController(DataContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Shop>> GetAll()
        {
            return await _context.Shops.ToListAsync();
        }

        [HttpGet("{id}")]

        public Shop GetShop(int id)
        {
            return _context.Shops.FirstOrDefault(s => s.id == id);
        }

        [HttpPost]
        public async Task Post(Shop item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }

        [HttpPut]
        public async Task Update(Shop item)
        {
            _context.Shops.Update(item);
            await _context.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var shop = _context.Shops.FirstOrDefault(s => s.id == id);

            if(shop != null)
            {
                _context.Remove(shop);
               await _context.SaveChangesAsync();
            }
        }
    }
}
