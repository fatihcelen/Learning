using System.Collections.Generic;
using TeknoLabs.Ardiye.Entities.Model;

namespace TeknoLabs.Ardiye.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

    }
}
