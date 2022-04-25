using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieCrud.Models;

namespace MovieCrud.Entity
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MovieContext _context;

        public Repository(MovieContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
