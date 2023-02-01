using System.Globalization;

namespace Mindbox
    {
        public abstract class Figure
        {
            public abstract string Area();

            public abstract string ShapeName();

            public void ShowInfo()
            {
                Console.WriteLine(
                    $"Название фигуры: {ShapeName()}\n" +
                    $"Площадь: {Area()}\n");

                Console.WriteLine();
            }
        }

        public class Triangle : Figure
        {
            double sideA, sideB, sideC;   // Стороны треугольника

            // Конструктор
            public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
            {
                SideA = triangleSideA;
                SideB = triangleSideB;
                SideC = triangleSideC;
            }

            // Свойство, проверяем значение на отрицательность.
            // Если значение отрицательное меняем его на аналогичное положительное.
            public double SideA
            {
                get { return sideA; }
                set { sideA = value < 0 ? -value : value; }
            }

            public double SideB
            {
                get { return sideB; }
                set { sideB = value < 0 ? -value : value; }
            }

            public double SideC
            {
                get { return sideC; }
                set { sideC = value < 0 ? -value : value; }
            }

            // Метод для вычисления площади треугольника
            public override string Area()
            {
            //Определяем гипотенузу
            double[] numbers = new[] { sideA, sideB, sideC };
            double max = numbers.Max();
            double side_first = sideA;
            double side_second = sideB;
            if (max== sideA)
            {
                 side_first = sideB;
                 side_second = sideC;
            }
            if (max == sideB)
            {
                side_first = sideA;
                side_second = sideC;
            }
            if (max == sideC)
            {
                side_first = sideA;
                side_second = sideB;
            }
            //Проверка на то, что треугольник прямоугольный
            if (side_first* side_first + side_second * side_second == max * max)
            {
                double ar_my = (side_first * side_second) / 2;
                return ar_my.ToString();
            }
            else
            {
                double p = (sideA + sideB + sideC) / 2;
                double result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                return result.ToString();
            }
        }


            // Метод возвращающий наименование фигуры
            public override string ShapeName()
            {
                return "Треугольник";
            }
        }

       public class Circle : Figure
        {
            double r;   // Радиус окружности

            // Конструктор
            public Circle(double circleSide)
            {
                R = circleSide;
             
            }

            // Свойство, проверяем значение на отрицательность.
            public double R
            {
                get { return r; }
                set { r = value < 0 ? -value : value; }
            }

            // Метод для вычисления площади окружности
            public override string Area()
            {
            double PI = 3.1415926535897931;
            return (r * r * PI).ToString();
            }

            // Метод возвращающий наименование фигуры
            public override string ShapeName()
            {
                return "Окружность";
            }
        }

    }

