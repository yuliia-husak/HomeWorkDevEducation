using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CarStore.Domain.Abstract;
using CarStore.Domain.Entities;
using CarStore.WebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CarStore.UnitTests
{
    [TestClass]
    public class AdminTests
    {        

        [TestMethod]
        public void Index_Contains_All_Cars()
        {
            // Организация - создание имитированного хранилища данных
            Mock<ICarRepository> mock = new Mock<ICarRepository>();
            mock.Setup(m => m.Cars).Returns(new List<Car>
            {
                new Car { CarId = 1, Name = "Car1"},
                new Car { CarId = 2, Name = "Car2"},
                new Car { CarId = 3, Name = "Car3"},
                new Car { CarId = 4, Name = "Car4"},
                new Car { CarId = 5, Name = "Car5"}
            });

            // Организация - создание контроллера
            AdminController controller = new AdminController(mock.Object);

            // Действие
            List<Car> result = ((IEnumerable<Car>)controller.Index().
                ViewData.Model).ToList();

            // Утверждение
            Assert.AreEqual(result.Count(), 5);
            Assert.AreEqual("Car1", result[0].Name);
            Assert.AreEqual("Car2", result[1].Name);
            Assert.AreEqual("Car3", result[2].Name);
        }
        [TestMethod]
        public void Can_Edit_Car()
        {
            // Организация - создание имитированного хранилища данных
            Mock<ICarRepository> mock = new Mock<ICarRepository>();
            mock.Setup(m => m.Cars).Returns(new List<Car>
            {
                new Car { CarId = 1, Name = "Car1"},
                new Car { CarId = 2, Name = "Car2"},
                new Car { CarId = 3, Name = "Car3"},
                new Car { CarId = 4, Name = "Car4"},
                new Car { CarId = 5, Name = "Car5"}
            });

            // Организация - создание контроллера
            AdminController controller = new AdminController(mock.Object);

            // Действие
            Car Car1 = controller.Edit(1).ViewData.Model as Car;
            Car Car2 = controller.Edit(2).ViewData.Model as Car;
            Car Car3 = controller.Edit(3).ViewData.Model as Car;

            // Assert
            Assert.AreEqual(1, Car1.CarId);
            Assert.AreEqual(2, Car2.CarId);
            Assert.AreEqual(3, Car3.CarId);
        }

        [TestMethod]
        public void Cannot_Edit_Nonexistent_Car()
        {
            // Организация - создание имитированного хранилища данных
            Mock<ICarRepository> mock = new Mock<ICarRepository>();
            mock.Setup(m => m.Cars).Returns(new List<Car>
            {
                new Car { CarId = 1, Name = "Car1"},
                new Car { CarId = 2, Name = "Car2"},
                new Car { CarId = 3, Name = "Car3"},
                new Car { CarId = 4, Name = "Car4"},
                new Car { CarId = 5, Name = "Car5"}
            });

            // Организация - создание контроллера
            AdminController controller = new AdminController(mock.Object);

            // Действие
            Car result = controller.Edit(6).ViewData.Model as Car;

            // Assert
        }


        [TestMethod]
        public void Can_Save_Valid_Changes()
        {
            // Организация - создание имитированного хранилища данных
            Mock<ICarRepository> mock = new Mock<ICarRepository>();

            // Организация - создание контроллера
            AdminController controller = new AdminController(mock.Object);

            // Организация - создание объекта Car
            Car Car = new Car { Name = "Test" };

            // Действие - попытка сохранения товара
            ActionResult result = controller.Edit(Car);

            // Утверждение - проверка того, что к хранилищу производится обращение
            mock.Verify(m => m.SaveCar(Car));

            // Утверждение - проверка типа результата метода
            Assert.IsNotInstanceOfType(result, typeof(ViewResult));
        }


        [TestMethod]
        public void Cannot_Save_Invalid_Changes()
        {
            // Организация - создание имитированного хранилища данных
            Mock<ICarRepository> mock = new Mock<ICarRepository>();

            // Организация - создание контроллера
            AdminController controller = new AdminController(mock.Object);

            // Организация - создание объекта Car
            Car Car = new Car { Name = "Test" };

            // Организация - добавление ошибки в состояние модели
            controller.ModelState.AddModelError("error", "error");

            // Действие - попытка сохранения товара
            ActionResult result = controller.Edit(Car);

            // Утверждение - проверка того, что обращение к хранилищу НЕ производится 
            mock.Verify(m => m.SaveCar(It.IsAny<Car>()), Times.Never());

            // Утверждение - проверка типа результата метода
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Can_Delete_Valid_Cars()
        {
            // Организация - создание объекта Game
            Car car = new Car { CarId = 2, Name = "Car2" };

            // Организация - создание имитированного хранилища данных
            Mock<ICarRepository> mock = new Mock<ICarRepository>();
            mock.Setup(m => m.Cars).Returns(new List<Car>
            {
                new Car { CarId = 1, Name = "Car1"},
                new Car { CarId = 2, Name = "Car2"},
                new Car { CarId = 3, Name = "Car3"},
                new Car { CarId = 4, Name = "Car4"},
                new Car { CarId = 5, Name = "Car5"}
            });

            // Организация - создание контроллера
            AdminController controller = new AdminController(mock.Object);

            // Действие - удаление игры
            controller.Delete(car.CarId);

            // Утверждение - проверка того, что метод удаления в хранилище
            // вызывается для корректного объекта Game
            mock.Verify(m => m.DeleteCar(car.CarId));
        }
    }
}
