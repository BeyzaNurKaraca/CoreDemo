using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal:IGenericDal<Category>
    {
        //IGenericDal da yazılan bütün metotlar burada da çalışacak

    }
}
