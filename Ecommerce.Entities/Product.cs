using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class Product : BaseEntities
    {
        public decimal Price { get; set; }
        public Category category { get; set; }
    }
}
