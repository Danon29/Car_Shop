using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDescription { set; get; }
        public string longDescription { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryID{ set; get; }

        public virtual Category Category { get; set; }
    }
}
