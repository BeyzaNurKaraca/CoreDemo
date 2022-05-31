using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class //tüm class a ait verileri kullanacak verdiğimiz T param.ı bütün entityleri ifade ediyor
        //yani kod tekrarı önlenmiş olacak sınıftaki her öğe için aşağıda tanımlanan metotlar kullanılacak.
        //ibaserepos ile aynı işlem.
    {

        void Insert(T t); 
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int Id);
    }
}
