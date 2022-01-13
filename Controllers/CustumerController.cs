using AutoMapper;
using EFCoreDemo.Controllers.Base;
using EFCoreDemo.Data;
using EFCoreDemo.Dtos;
using EFCoreDemo.Entities;
using EFCoreDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : GenericControllerBase<CustomerDto, Customer>
    {

        public CustomerController(DataContext context, IMapper mapper, GenericRepository<Customer> repository) : base(context, mapper, repository)
        {
        }

    }
}
