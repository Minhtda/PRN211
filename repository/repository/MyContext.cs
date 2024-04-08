using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class MyContext: DbContext
    {
        //public DbSet<TestModel> Tess { get; set; }
        public DbSet<minh> minh { get; set; }
        public MyContext():base(new DbContextOptions<MyContext>())
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                //catalog la ten database ID, password dat theo de
                builder.UseSqlServer("Data Source=(local);Initial Catalog=minh;User ID=sa;Password=12345");
            }
        }
    }

   

    public class Repo<T> where T : BaseModel
    {
        private readonly MyContext _context;
        private readonly DbSet<T> _dbSet;
        public Repo()
        {
            _context = new MyContext();
            _dbSet = _context.Set<T>();
        }

        public T Get(Guid id)
        {
            return _dbSet.FirstOrDefault(x=>x.Id==id);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            //_dbSet.Update(entity);
            _context.SaveChanges();
        }
    }

    
}
