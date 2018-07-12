using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.Ardiye.Business.Abstract;
using TeknoLabs.Ardiye.DataAccess.Abstract;
using TeknoLabs.Ardiye.Entities.Model;

namespace TeknoLabs.Ardiye.Business.Model
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product() { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
