using Finance.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Finance.Access.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly FinanceContext _context;
        private readonly ILogger<Repository<T>> _logger;

        public Repository(FinanceContext context, ILogger<Repository<T>> logger)
        {
            _context = context;
            _logger = logger;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IList<T> Search(Func<T, bool>[] filters)
        {
            var query = _context.Set<T>().AsQueryable();

            foreach (var filter in filters)
            {
                query = query.Where(filter).AsQueryable();
            }

            return query.ToList();
        }

        public T Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred at add the object in DB.");
            }

            return entity;
        }
    }
}
