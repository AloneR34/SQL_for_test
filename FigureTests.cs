using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Tests
{
    [TestClass()]
    public class FigureTests
    {
        //Проверка расчета площади прямоугольного треугольника
        [TestMethod()]
        public void TriangleTest1()
        {
            // Arrange
            double SideA = 3;
            double SideB = 4;
            double SideC = 5;
            Triangle tri = new Triangle(SideA, SideB, SideC);

            // Act
            string Probably_result=tri.Area();

            // Assert
            
            Assert.AreEqual(Probably_result, "6");
        }
        //Проверка расчета площади треугольника по трем сторонам
        [TestMethod()]
        public void TriangleTest2()
        {
            // Arrange
            double SideA = 8;
            double SideB = 4;
            double SideC = 5;
            Triangle tri = new Triangle(SideA, SideB, SideC);

            // Act
            string Probably_result = tri.Area();

            // Assert

            Assert.AreEqual(Probably_result, "8,181534085976786");
        }
        //Проверка расчета площади окружности
        [TestMethod()]
        public void CircleTest1()
        {
            // Arrange
            double R = 10;
            
            Circle cri = new Circle(R);

            // Act
            string Probably_result = cri.Area();

            // Assert

            Assert.AreEqual(Probably_result, "314,1592653589793");
        }
    }
}