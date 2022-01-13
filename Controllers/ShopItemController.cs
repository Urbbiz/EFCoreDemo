using AutoMapper;
using EFCoreDemo.Controllers.Base;
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
    public class ShopItemController : GenericControllerBase<ShopItemDto, ShopItem>
    {
    
        public ShopItemController(DataContext context, IMapper mapper, GenericRepository<ShopItem> repository) : base(context, mapper, repository)
        {
        }

    }
}
