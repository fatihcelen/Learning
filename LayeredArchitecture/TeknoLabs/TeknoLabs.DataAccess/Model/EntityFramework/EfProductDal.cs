using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.Ardiye.DataAccess.Abstract;
using TeknoLabs.Ardiye.Entities.Model;
using TeknoLabs.Core.DataAccess.EntityFramework;

namespace TeknoLabs.Ardiye.DataAccess.Model.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,ArdiyeContext>,IProductDal
    {
    }
}
