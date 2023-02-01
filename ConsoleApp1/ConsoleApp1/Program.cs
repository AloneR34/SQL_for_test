// See https://aka.ms/new-console-template for more information
using Mindbox; // подключение библиотеки


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Figure figure1 = new Triangle(8, 4, 5);
            figure1.ShowInfo();


            Figure figure2 = new Circle(10);
            figure2.ShowInfo();

            Console.ReadKey();
        }
    }
}
