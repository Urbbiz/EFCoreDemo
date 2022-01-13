using AutoMapper;
using EFCoreDemo.Controllers.Base;
using EFCoreDemo.Data;
using EFCoreDemo.Dtos;
using EFCoreDemo.Entities;
using EFCoreDemo.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : GenericControllerBase<ShopDto, Shop>
    {

        public ShopController(IMapper mapper, GenericRepository<Shop> repository) : base(mapper, repository)
        {
        }

        
    }
}
