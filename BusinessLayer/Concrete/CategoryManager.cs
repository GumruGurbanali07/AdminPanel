using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        private readonly GenericRepository<Category> repo;

        public CategoryManager(DbContextOptions<AppDbContext> options)
        {
            repo = new GenericRepository<Category>(options);
        }
        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void AddCategory(Category p)
        {
            repo.Insert(p);
        }
    }
}
