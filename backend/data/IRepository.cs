using System.Threading.Tasks;
using backend.models;

namespace backend.data
{
     public interface IRepository
     {
          void Add<T>(T entity) where T : class;
          Task<bool> SaveChangesAsync();

          Task<Jogo[]> GetAllJogos();
          Task<Jogo> GetJogoById(int id);

     }
}