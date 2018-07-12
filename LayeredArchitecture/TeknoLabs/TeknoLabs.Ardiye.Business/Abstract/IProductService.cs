using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.Ardiye.Entities.Model;

namespace TeknoLabs.Ardiye.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);

    }
}
