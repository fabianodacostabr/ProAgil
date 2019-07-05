
using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public class ProAgilRepository: IProAgilRepository
    {
        private readonly ProAgilContext _context;

        public ProAgilRepository(ProAgilContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }       

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        public Task<Evento> GetAllEventoAsyncById(int eventoid, bool incluirPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(bool incluirPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsyncByTema(string tema, bool incluirPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante> GetAllPalestranteAsync(bool incluirPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsyncByNome(string nome, bool incluirPalestrantes)
        {
            throw new System.NotImplementedException();
        }

        
    }
}