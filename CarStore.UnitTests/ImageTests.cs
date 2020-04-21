using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CarStore.Domain.Abstract;
using CarStore.Domain.Entities;
using CarStore.WebUI.Controllers;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace CarStore.UnitTests
{
    [TestClass]
    public class ImageTests
    {
        [TestMethod]
        public void Can_Retrieve_Image_Data()
        {
            // Организация - создание объекта Game с данными изображения
            Car car = new Car
            {
                CarId = 2,
                Name = "Car2",
                ImageData = new byte[] { },
                ImageMimeType = "image/png"
            };

            // Организация - создание имитированного хранилища
            Mock<ICarRepository> mock = new Mock<ICarRepository>();
            mock.Setup(m => m.Cars).Returns(new List<Car> {
                new Car {CarId = 1, Name = "Car1"},
                car,
                new Car {CarId = 3, Name = "Car3"}
            }.AsQueryable());

            // Организация - создание контроллера
            CarController controller = new CarController(mock.Object);

            // Действие - вызов метода действия GetImage()
            ActionResult result = controller.GetImage(2);

            // Утверждение
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(FileResult));
            Assert.AreEqual(car.ImageMimeType, ((FileResult)result).ContentType);
        }

        [TestMethod]
        public void Cannot_Retrieve_Image_Data_For_Invalid_ID()
        {
            // Организация - создание имитированного хранилища
            Mock<ICarRepository> mock = new Mock<ICarRepository>();
            mock.Setup(m => m.Cars).Returns(new List<Car> {
                new Car {CarId = 1, Name = "Car1"},
                new Car {CarId = 2, Name = "Car2"}
            }.AsQueryable());

            // Организация - создание контроллера
            CarController controller = new CarController(mock.Object);

            // Действие - вызов метода действия GetImage()
            ActionResult result = controller.GetImage(10);

            // Утверждение
            Assert.IsNull(result);
        }
    }
}

