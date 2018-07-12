using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.Core.Entites;

namespace TeknoLabs.Ardiye.Entities.Model
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
