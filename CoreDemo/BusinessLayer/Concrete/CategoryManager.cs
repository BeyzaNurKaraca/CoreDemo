using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
     public class CategoryManager : ICategoryService
    {
        //Üzerinde çalışmış olduğumuz manager sınıfı içerisinde efcategoryrepten bir değer oluşturacağız
        // EntityFrameworkCategoryRepository entityFrameworkCategoryRepository;
        //çalıştığımız manager üzerine atama yapabilmek için constractor bir metot oluşturmamız gerekiyor

        EntityFrameworkCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository= new EntityFrameworkCategoryRepository();
        }
      
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.AddCategory(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.DeleteCategory(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.UpdateCategory(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
