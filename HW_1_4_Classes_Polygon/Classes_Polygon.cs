using System.Net.Security;
using System.Text;

namespace HW_1_4_Classes_Polygon
{
    internal class Classes_Polygon
    {

        //Створити класи Point та Figure.
        //Клас Point повинен містити два цілих поля і одне рядкове поле.
        //Створити три властивості одним методом доступу get. Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів.
        //Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.
        //Створити два методи:
        //double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника;
        //void PerimeterCalculator(), що розраховує периметр багатокутника.
        //Написати програму, яка виводить на екран назву та периметр багатокутника.

        public const byte MaxCorner = 10;
        public static string[] polyNames = new string[] { "", "Точка", "Відрізок", "Трикутник", "Чотирикутник", "Пентагон", "Секстагон", "Гептагон", "Октагон", "Нонагон", "Декагон" };

        class Point
        {
            int x, y;
            string name;
            public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }
            public int X { get { return x; } }
            public int Y { get { return y; } }
            string Name { get { return name; } }
        }

        class Figure
        {
            Point[] points;
            readonly byte nCorner;
            string figName;
            double perimeter;   //Периметр розраховуєиться один раз, не в конструкторі, в при виклику get перисметра чи ознаки regular. 
            bool regular;       //"Чи багатокутник правильнмй?" Найпростіше - ваажаємо прравильним, коли усі стороні рівні (рівність кутів ігоруємо).
                                //regular отримує значення тільки після того,як був розрахований периметр

            public Figure(params Point[] points)
            {
                nCorner = (byte)points.Length;
                regular = false;
                perimeter = 0;

                if (nCorner > 1 && nCorner <= MaxCorner)
                {
                    //this.points = new Point[nCorner];
                    this.points = points;
                    //int rr = this.points[1].X;
                    this.figName = polyNames[nCorner];
                }
                else
                {

                }
            }

            private double LengthSide(Point A, Point B)
            {
                double x1_x2_2 = Math.Pow((B.X - A.X), 2);
                double y1_y2_2 = Math.Pow((B.Y - A.Y), 2);
                return Math.Sqrt(x1_x2_2 + y1_y2_2); ;
            }
            private double PerimeterCalculator()
            {
                bool isEqual = true;
                double anySide = LengthSide(points[nCorner - 1], points[0]);
                double perimeterSum = anySide;
                for (byte i = 0; i < nCorner - 1; i++)
                {
                    double nextSide = LengthSide(points[i], points[i + 1]);
                    perimeterSum += nextSide;
                    if (isEqual) { isEqual = anySide == nextSide; anySide = nextSide; }

                }
                regular = isEqual;
                return perimeterSum;
            }
            public string FigureName
            {
                //Якщо багатокутник виявися правильним, то привласнюється латинське і'мя (типу октагон).
                //Якщо неправильний (regular=false), то до "Октагону" на початок додається "не є"
                get
                {
                    if (perimeter == 0)
                    {
                        perimeter = PerimeterCalculator();
                        string negation = "не є ";
                        if (regular) { negation = ""; }
                        figName = negation + figName;
                    }
                    return figName;
                }
            }
            public byte NumberOfCorners { get { return nCorner; } }
            public bool IsRegular
            {
                get
                {
                    if (perimeter == 0)
                    {
                        perimeter = PerimeterCalculator();
                    }
                    return regular;
                }
            }
            public double Perimeter
            {
                get
                {
                    if (perimeter == 0)
                    {
                        perimeter = PerimeterCalculator();
                    }
                    return perimeter;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Hello, World!\nКласи. Багатокутник.\n");
            //Console.Write("N-кутник. Введіть N (скільки кутів): ");
            //byte nCorner = Convert.ToByte(Console.ReadLine());
            /*Point[] points = new Point[5];
            for (byte i = 0; i < 6; i++)
            {
                points[i] = new Point(10, 12, "A");
            }*/

            Point[] points = {
             new Point(11,12,"A"),
             new Point(14,15,"B"),
             new Point(17,20,"C"),
             new Point(25,30,"D"),
             new Point(40,51,"E"),
             new Point(60,70,"F"),
             new Point(160,70,"AA"),
             new Point(610,70,"AB")
             };

            Figure figure = new Figure(points);

            Console.WriteLine($"Цей {figure.NumberOfCorners:G}-кутник " + figure.FigureName + $".\nЙого периметер = {figure.Perimeter:G}");

            Console.ReadKey();
        }
    }
}