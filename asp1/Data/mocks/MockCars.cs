using asp1.Data.Interfaces;
using asp1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car 
                    {
                        name = "Tesla",
                        shortDescription = "Something again",
                        img = "/img/tesla.jpg",
                        price = 1000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Matiz",
                        shortDescription = "Something again",
                        img = "/img/matiz.jpg",
                        price = 10020,
                        isFavourite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "bmw",
                        shortDescription = "Something again",
                        img = "/img/bmw.jpg",
                        price = 1000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "toyota",
                        shortDescription = "Something again",
                        img = "/img/toyota.jpg",
                        price = 10100,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
