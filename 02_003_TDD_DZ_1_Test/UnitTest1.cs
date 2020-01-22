using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_003_TDD_DZ_1;

namespace _02_003_TDD_DZ_1_Test
{
    [TestClass]
    public class SqrTest
    {
        [TestMethod]
        public void BasicRoobTest()
        {
            //Экземпляр тестируемого класса
            Sqr sqr1 = new Sqr();

            //Определение входного и выходного значения
            double expectedResult = 5.65;

            double input = expectedResult * expectedResult;

            //Запуск тестируемого метода
            double actualResult = Sqr.SqureRoot(input);

            //Проверка результата
            Assert.AreEqual(expectedResult, actualResult,
                delta: expectedResult / 1000);
        }

        [TestMethod]
        public void RooterValueRange()
        {
            Sqr sqr1 = new Sqr();

            for (double expectedResult = 1e-8;
                expectedResult < 1e+8;
                expectedResult *= 2)
            {
                RooterOneValue(sqr1, expectedResult);
            }
        }
        private void RooterOneValue(Sqr sqr1, double expectedResult)
        {
            double input = expectedResult * expectedResult;

            double actualResult = Sqr.SqureRoot(input);


            Assert.AreEqual(expectedResult, actualResult,
                delta: expectedResult / 1000);
        }

        [TestMethod]
        // [ExpectedException=]
        public void RooterTestNegativeInputx()
        {
            Sqr sqr1 = new Sqr();

            try
            {
                Sqr.SqureRoot(-10);
                //Assert.Fail("*****");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail();//Тест не проходит если Catch не срабатывает            
                return;
            }

            //Assert.Fail();//Тест не проходит если Catch не срабатывает
        }
    }
}
