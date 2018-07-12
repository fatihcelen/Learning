using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.Ardiye.Business.Abstract;
using TeknoLabs.Ardiye.DataAccess.Abstract;
using TeknoLabs.Ardiye.Entities.Model;

namespace TeknoLabs.Ardiye.Business.Model
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
