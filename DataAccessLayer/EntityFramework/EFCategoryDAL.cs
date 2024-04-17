using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
    {
        public EFCategoryDAL(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
