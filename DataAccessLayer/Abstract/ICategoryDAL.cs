using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDAL
    {
        List<Category> List();
        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);//proyekti deyisdim birde bundan atmamisam hec
    }
}
