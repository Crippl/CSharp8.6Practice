using static System.Console;
using System.Xml.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "ContactBook.xml";
            Write("Введите ФИО контакта: ");
            string someFIO = ReadLine();
            Write("Введите улицу: ");
            string someStreet = ReadLine();
            Write("Введите номер дома: ");
            int someHouseNumber = int.Parse(ReadLine());
            Write("Введите номер квартиры: ");
            int someFlatNumber = int.Parse(ReadLine());
            Write("Введите номер мобильного телефона: ");
            int someMobilePhone = int.Parse(ReadLine());
            Write("Введите номер домашнего телефона: ");
            int someFlatPhone = int.Parse(ReadLine());

            XElement Contact = new XElement("Contact");
            XElement Address = new XElement("Address",
                new XElement("Street",someStreet),
                new XElement("HouseNumber",someHouseNumber),
                new XElement("FlatNumber",someFlatNumber)
                );
            XElement Phones = new XElement("Phones",
                new XElement("MobilePhone", someMobilePhone),
                new XElement("FlatPhone",someFlatPhone)
                );
            XAttribute xFIO = new XAttribute("ФИО", someFIO);

            Contact.Add(Address, Phones, xFIO);
            Contact.Save(path);

            ReadLine();
        }
    }
}
