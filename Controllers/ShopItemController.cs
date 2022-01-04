using EFCoreDemo.Data;
using EFCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : Controller
    {
        private readonly DataContext _context;

        public ShopItemController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]   
        public List<ShopItem> GetAll()
        {
            return _context.ShopItems.ToList();
        }

        [HttpPost]
        public void Post(ShopItem item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
    }
}
