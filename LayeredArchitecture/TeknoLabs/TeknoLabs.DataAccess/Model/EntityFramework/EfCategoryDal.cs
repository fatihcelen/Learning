using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TeknoLabs.Ardiye.DataAccess.Abstract;
using TeknoLabs.Ardiye.Entities.Model;
using TeknoLabs.Core.DataAccess.EntityFramework;

namespace TeknoLabs.Ardiye.DataAccess.Model.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Product, ArdiyeContext>, ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
