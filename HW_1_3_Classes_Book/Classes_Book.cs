using System.Text;

namespace HW_1_3_Classes_Book
{
    internal class Classes_Book
    {
        //Створити клас Book. Створити класи Title, Author та Content, кожен з яких повинен містити одне рядкове поле та метод void Show().
        //Реалізуйте можливість додавання до книги назви книги, імені автора та змісту.
        //Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.
        class Title
        {
            string content;
            public string Content
            {
                private get
                {
                    if (content != null)
                        return content;
                    else
                        return "<Титул відсутній>";
                }
                set
                {
                    content = value;
                }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Content);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        class Author
        {
            string content;
            public string Content
            {
                private get
                {
                    if (content != null)
                        return content;
                    else
                        return "<Автор відсутній>";
                }
                set
                {
                    content = value;
                }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Content);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        class Зміст
        {
            string content;
            public string Content
            {
                private get
                {
                    if (content != null)
                        return content;
                    else
                        return "<Вміст відсутній>";
                }
                set
                {
                    content = value;
                }
            }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(Content);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        class Book
        {
            // Поля

            private Title title;
            private Author author;
            private Зміст зміст;

            // Властивості
            public string Title
            {
                set
                {
                    this.title.Content = value;
                }
            }
            public string Author
            {
                set
                {
                    this.author.Content = value;
                }
            }
            public string Зміст
            {
                set
                {
                    this.зміст.Content = value;
                }
            }

            public Book()
            {//Це конструктор за замовченням. Очевидний.
                this.title = new Title();
                this.author = new Author();
                this.зміст = new Зміст();
            }

            public Book(Title title, Author author, Зміст зміст)
            {//Цей конструктор - коли користувач визиватиме створення Book із заздагледь створеними зовні полями,
             //на які сюди передаються посилання. Тут конструктор за замовченням не використовується, бо поля вже створені.
                this.title = title;
                this.author = author;
                this.зміст = зміст;
            }

            public Book(string title, string author, string content) : this()
            {//Цей конструктор - коли користувач визиватиме створення Book з параметрами.
             //Перед застосуванням параметрів поля також треба створити, тому викликаний за замовченням : this()
                this.title.Content = title;
                this.author.Content = author;
                this.зміст.Content = content;
            }

            public void Show()
            {
                this.title.Show();
                this.author.Show();
                this.зміст.Show();
            }
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Hello, World!\nКласи. Book.\n");

            Book book1 = new Book();
            Console.WriteLine("Книга 1: ");
            book1.Show();
            Console.WriteLine();

            Book book2 = new Book("Малий кобрар", "Шевченко Т.Г.", "Вірші");
            Console.WriteLine("Книга 2: ");
            book2.Show();
            Console.WriteLine();

            Book book3 = new Book();
            Console.WriteLine("Книга 3: ");
            Console.Write("Книга 3. Яка назва? ");
            book3.Title = Console.ReadLine();
            Console.Write("Книга 3. Хто автор? ");
            book3.Author = Console.ReadLine();
            Console.Write("Книга 3. Хоча б рядок зміста: ");
            book3.Зміст = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Книга 3: ");
            book3.Show();

            Console.ReadKey();
        }
    }
}