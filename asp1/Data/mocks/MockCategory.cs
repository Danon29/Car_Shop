using asp1.Data.Interfaces;
using asp1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Электромобили", Description = "Something useful"},
                    new Category { CategoryName = "Классические автомобили", Description = "Something useful one more time"}
                };
            }
        } 
    }
}
