namespace Cars.Tests.JustMock
{
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using Cars.Tests.JustMock.Mocks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            //: this(new JustMockCarsRepository())
             : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllFiveCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(5, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnTheDefaultCarDetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        // My tests -------------------------------------------------------------------------------------------
        [TestMethod]
        public void DetailsShouldWorkProperWhenPassedValidId()
        {
            var car = (Car)this.GetModel(() => this.controller.Details(5));

            Assert.AreEqual(5, car.Id);
            Assert.AreEqual("Audi", car.Make);
            Assert.AreEqual("A3", car.Model);
            Assert.AreEqual(2009, car.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailsShouldThrowExceptionWhenCarWithIvalidIdZeroIsPassed()
        {
            var carWithIdZero = (Car) this.GetModel(() => this.controller.Details(0));

        }

        [TestMethod]
        
        public void DetailsShouldReturnDefaultCarWhenIvalidIdNegativeIsPassed()
        {
            var carWithIdTen = (Car)this.GetModel(() => this.controller.Details(-5));

            Assert.AreEqual(1, carWithIdTen.Id);
        }

        [TestMethod]
        public void SearchShouldReturnCollectionOfTwoCarsWhenSearchForBmw()
        {
            IList<Car> cars = (IList<Car>)this.GetModel(() => this.controller.Search("BMW"));

            Assert.AreEqual(2, cars.Count);
        }

        [TestMethod]
        public void SearchShouldReturnCollectionOfBmwCarsWhenSearchForBmw()
        {
            IList<Car> cars = (IList<Car>)this.GetModel(() => this.controller.Search("BMW"));

            foreach (var car in cars)
            {
                Assert.AreEqual("BMW", car.Make);
            }
        }

        [TestMethod]
        public void SearchShouldReturnCollectionOfAudiCarsWhenSearchForAudi()
        {
            IList<Car> cars = (IList<Car>)this.GetModel(() => this.controller.Search("Audi"));

            foreach (var car in cars)
            {
                Assert.AreEqual("Audi", car.Make);
            }
        }

        [TestMethod]
        public void SortByYearShouldWorkProper()
        {
            var sortedCars = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            int counter = 0;
            foreach (var car in sortedCars)
            {
                Assert.AreEqual(2005 + counter, sortedCars[counter].Year);
            }
        }

        [TestMethod]
        public void SortByMakeShouldWorkProper()
        {
            var sortedCars = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual("Audi", sortedCars[0].Make);
            Assert.AreEqual("Audi", sortedCars[1].Make);
            Assert.AreEqual("BMW", sortedCars[2].Make);
            Assert.AreEqual("BMW", sortedCars[3].Make);
            Assert.AreEqual("Opel", sortedCars[4].Make);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
