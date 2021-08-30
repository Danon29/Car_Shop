using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public List<Car> cars { set; get; }

    }
}
