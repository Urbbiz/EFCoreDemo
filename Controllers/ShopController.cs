using EFCoreDemo.Data;
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
    }
}
