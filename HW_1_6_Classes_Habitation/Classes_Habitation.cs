using System.Drawing;
using System.Text;

namespace HW_1_6_Classes_Habitation
{
    internal class Classes_Habitation
    {
        //Створити клас із ім'ям Address.
        //У тілі класу потрібно створити поля: index, country, city, street, house, apartment.
        //Для кожного поля створити властивість з двома методами доступу.
        //Створити екземпляр класу Address. У поля екземпляра записати інформацію про поштову адресу.
        //Виведіть на екран значення полів, що описують адресу.

        class Address
        {
            public int Index { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public ushort House { get; set; }
            public ushort Apartment { get; set; }

            public Address(int Index, string Country, string City, string Street, ushort House, ushort Apartment)
            {
                this.Index= Index;
                this.Country= Country; 
                this.City= City;
                this.Street= Street;
                this.House= House;
                this.Apartment= Apartment;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Hello, World!\nКласи. Житло.\n");

            Address habitation = new(61177,"Ausralia","Melburn","Jackson avenu",13,31);

            Console.WriteLine($"Місце проживання:\n{habitation.Index:G}\n{habitation.Country:G}");
            Console.WriteLine($"{habitation.City:G}\n{habitation.Street:G}\n{habitation.House:G}\n{habitation.Apartment:G}");

            Console.ReadKey();
        }
    }
}