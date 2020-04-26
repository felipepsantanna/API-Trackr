using API.TRACKR.Data;
using API.TRACKR.Models;
using Microsoft.EntityFrameworkCore;


namespace API.TRACKR.Data
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected DbSet<T> dbSet { get; set; }

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
