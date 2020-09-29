using System.Linq;
using System.Threading.Tasks;
using backend.models;
using Microsoft.EntityFrameworkCore;

namespace backend.data
{
     public class Repository : IRepository
     {
         private readonly DataContext _context;

         public Repository(DataContext context)
          {
               this._context = context;
          }

          public void Add<T>(T entity) where T : class
          {
               _context.Add(entity);
          }

          public async Task<bool> SaveChangesAsync()
          {
               return (await _context.SaveChangesAsync()) > 0;
          }

          public async Task<Jogo[]> GetAllJogos()
          {
               IQueryable<Jogo> query = _context.Jogo;
               query = query.AsNoTracking().OrderBy(a => a.Id);
               return await query.ToArrayAsync();
          }

          public async Task<Jogo> GetJogoById(int id)
          {
               IQueryable<Jogo> query = _context.Jogo;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == id);

               return await query.FirstOrDefaultAsync();
          }
     }
}