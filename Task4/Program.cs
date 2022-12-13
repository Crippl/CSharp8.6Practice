using static System.Console;
using System.Xml.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement Contact = new XElement("Contact");
            XElement Address = new XElement("Address");
            XElement Street = new XElement("Street");
            XElement HouseNumber = new XElement("HouseNumber");
            XElement FlatNumber = new XElement("FlatNumber");
            XElement Phones = new XElement("Phones");
            XElement MobilePhone = new XElement("MobilePhone");
            XElement FlatPhone = new XElement("FlatPhone");
            string path = "ContactBook.xml";

            Write("Введите ФИО контакта: ");
            XAttribute xFIO = new XAttribute("ФИО",ReadLine());
            Write("Введите улицу: ");
            XAttribute xStreet = new XAttribute("Улица", ReadLine());
            Write("Введите номер дома: ");
            XAttribute xHouseNumber = new XAttribute("Дом", ReadLine());
            Write("Введите номер квартиры: ");
            XAttribute xFlatNumber = new XAttribute("Квартира", ReadLine());
            Write("Введите номер мобильного телефона: ");
            XAttribute xMobilePhone = new XAttribute("Мобильный", ReadLine());
            Write("Введите номер домашнего телефона: ");
            XAttribute xFlatPhone = new XAttribute("Домашний", ReadLine());

            MobilePhone.Add(xMobilePhone);
            FlatPhone.Add(xFlatPhone);
            Street.Add(xStreet);
            HouseNumber.Add(xHouseNumber);
            FlatNumber.Add(xFlatNumber);

            Phones.Add(MobilePhone, FlatPhone);
            Address.Add(Street, HouseNumber, FlatNumber);
            Contact.Add(Address, Phones,xFIO);

            Contact.Save(path);
            ReadLine();
        }
    }
}
