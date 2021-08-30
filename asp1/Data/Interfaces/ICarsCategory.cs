using asp1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.Data.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
