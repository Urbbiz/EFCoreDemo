using EFCoreDemo.Data;
using EFCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : Controller
    {
        private readonly DataContext _context;

        public ShopController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public List<Shop> GetAll()
        {
            return _context.Shops.ToList();
        }

        [HttpGet("{id}")]

        public Shop GetShop(int id)
        {
            return _context.Shops.FirstOrDefault(s => s.id == id);
        }

        [HttpPost]
        public void Post(Shop item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        [HttpPut]
        public void Update(Shop item)
        {
            _context.Shops.Update(item);
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var shop = _context.Shops.FirstOrDefault(s => s.id == id);

            if(shop != null)
            {
                _context.Remove(shop);
                _context.SaveChanges();
            }
        }
    }
}
