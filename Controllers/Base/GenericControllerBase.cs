using AutoMapper;
using EFCoreDemo.Data;
using EFCoreDemo.Dtos.Base;
using EFCoreDemo.Entities.Base;
using EFCoreDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDemo.Controllers.Base
{
    public class GenericControllerBase<TDto, TEntity> : ControllerBase where TDto :DtoObject where TEntity : Entity
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly GenericRepository<TEntity> _repository;


        public GenericControllerBase(DataContext context, IMapper mapper, GenericRepository<TEntity> repository)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<TDto>> GetAll()
        {
            // var enteties = await _context.ShopItems.ToListAsync();
            var enteties = await _repository.GetAll();
            var dto = _mapper.Map<List<TDto>>(enteties);
            return dto;

        }

        [HttpGet("{id}")]

        public TDto GetShop(int id)
        {
            var entity = _repository.FinidById(id);
            return _mapper.Map<TDto>(entity);
        }

        [HttpPost]
        public async Task Post(TDto item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }

        [HttpPut]
        public async Task Update(TDto item)
        {
            //_context.Shops.Update(item);
            _context.Update(item);
            await _context.SaveChangesAsync();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
            //var shop = _context.Shops.FirstOrDefault(s => s.id == id);

            //if(shop != null)
            //{
            //    _context.Remove(shop);
            //   await _context.SaveChangesAsync();
            //}
        }
    }
}
