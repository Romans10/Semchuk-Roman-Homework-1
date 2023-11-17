using System.Text;

namespace HW_1_2_Classes_Rectangle
{
    internal class Classes_Rectangle
    {
        //Створити клас із ім'ям Rectangle. У тілі класу створити два поля, що описують довжини сторін double side1, side2.
        //Створити власний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2
        //ініціалізуються значеннями аргументів.
        //Створити два методи, що обчислюють площу прямокутника - double AreaCalculator()
        //та периметр прямокутника - double PerimeterCalculator().
        //Створити дві властивості double Area та double Perimeter з одним методом доступу get.
        //Написати програму, яка приймає від користувача довжини двох сторін прямокутника
        //і виводить на екран периметр та площу. 

        class Rectangle
        {
            private double side1, side2;
            public Rectangle(double a_side1, double a_side2)
            {
                side1 = a_side1;
                side2 = a_side2; ;
            }
            private double AreaCalculator()
            {
                return side1 * side2;
            }
            private double PerimeterCalculator()
            {
                return (side1 + side2) * 2;
            }
            public double Area
            {
                get
                {
                    return AreaCalculator();
                }
            }
            public double Perimeter
            {
                get
                {
                    return PerimeterCalculator();

                }
            }

            static void Main(string[] args)
            {

                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;

                Console.WriteLine("Hello, World!\nКласи. Прямокутники\n");

                Console.Write("Прямокутник. Введіть довжину: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Прямокутник. Введіть ширину: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Rectangle theRectangle = new Rectangle(length, width);

                Console.WriteLine($"Периметр прямокутника: {theRectangle.Perimeter:G}");
                Console.WriteLine($"Площа прямокутника: {theRectangle.Area:G}");

                Console.ReadKey();
            }
        }
    }
}