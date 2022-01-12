using AutoMapper;
using EFCoreDemo.Data;
using EFCoreDemo.Entities.Base;

namespace EFCoreDemo.Repositories
{
    public class GenericRepository<T> where T : Entity
    {
        private readonly DataContext _context;
   

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public T FinidById(int id)
        {
            var entity = _context.Set<T>().FirstOrDefault(e => e.id == id);
            if (entity == null)
            {
                throw new ArgumentException("");
            }
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity =_context.Set<T>().FirstOrDefault(e => e.id == id);

            if (entity != null)
            {
                _context.Remove(entity);
            }
            await _context.SaveChangesAsync();
        }
    }
}
