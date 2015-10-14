using System;

namespace Cars.Tests.JustMock.Mocks
{
    using Cars.Contracts;
    using Cars.Models;
    using Moq;
    using System.Linq;

    public class MoqCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            var mockedCarsRepository = new Mock<ICarsRepository>();

            // Add
            mockedCarsRepository.Setup(r => r.Add(It.IsAny<Car>())).Verifiable();

            // Remove
            mockedCarsRepository.Setup(r => r.Remove(It.IsAny<Car>())).Verifiable();

            // GetById
            mockedCarsRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns(this.FakeCarCollection.FirstOrDefault());
            mockedCarsRepository.Setup(r => r.GetById(It.IsInRange<int>(0, this.FakeCarCollection.Count, Range.Inclusive)))
                .Returns((int id) => this.FakeCarCollection.FirstOrDefault(z => z.Id == id));
            /*mockedCarsRepository.Setup(r => r.GetById(It.IsInRange<int>(-1, Int32.MinValue, Range.Inclusive)))
                .Throws<ArgumentNullException>();*/
                

            // All();
            mockedCarsRepository.Setup(r => r.All()).Returns(this.FakeCarCollection);

            // SortedByMake();
            mockedCarsRepository.Setup(r => r.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(c => c.Make).ToList());

            // SortedByYear();
            mockedCarsRepository.Setup(r => r.SortedByYear()).Returns(this.FakeCarCollection.OrderBy(c => c.Year).ToList());

            // ICollection<Car> Search(string condition);
            mockedCarsRepository.Setup(r => r.Search(It.Is<string>(x => x == "BMW"))).Returns(this.FakeCarCollection.Where(c => c.Make == "BMW").ToList());
            mockedCarsRepository.Setup(r => r.Search(It.Is<string>(x => x == "Audi"))).Returns(this.FakeCarCollection.Where(c => c.Make == "Audi").ToList());
            mockedCarsRepository.Setup(r => r.Search(It.Is<string>(x => x == "Opel"))).Returns(this.FakeCarCollection.Where(c => c.Make == "Opel").ToList());

            this.CarsData = mockedCarsRepository.Object;
        }
    }
}
