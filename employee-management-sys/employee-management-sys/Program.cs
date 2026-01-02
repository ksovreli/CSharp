using EighthConsoleApp.Enums;
using EighthConsoleApp.Models;

static void PrintEmploys(Country country)
{
    Employ[] employs = new Employ[8]
    {
        new Employ("Sandro", "Ksovreli", "Web Developer", new DateTime(2010, 01, 14), 3545, Country.Georgia, Gender.Male, Contacts.Email),

        new Employ("Mate", "Ksovreli", "No Job", new DateTime(2010, 01, 14), 0, Country.Georgia, Gender.Male, Contacts.Email),

        new Employ("Oto", "Edisherashvili", "No Job", new DateTime(2008, 11, 01), 0, Country.Germany, Gender.Male, Contacts.Phone),

        new Employ("Gio", "Lazarashvili", "FC Club", new DateTime(2009, 11, 20), 1435, Country.Sweden, Gender.Male, Contacts.Fax),

        new Employ("Mariam", "Baratashvili", "UI/UX Designer", new DateTime(2006, 04, 06), 7523, Country.Georgia, Gender.Male, Contacts.Fax),

        new Employ("Saba", "Tkemaladze", "Audit", new DateTime(2007, 2, 2), 4512, Country.Germany, Gender.Male, Contacts.Fax),

        new Employ("Luka", "Beridze", "Cocacola Company", new DateTime(1992, 01, 2), 1435, Country.USA, Gender.Male, Contacts.Email),

        new Employ("John", "Dohn", "Cybersecurity", new DateTime(2000, 01, 01), 10000000, Country.USA, Gender.PreferNotToSay, Contacts.Phone)
    };

    Console.WriteLine($"\n\t\t\t\t\t\t\tFrom: {country}");

    foreach (var e in employs)
    {
        if (e.Country == country)
        {
            e.Print();
        }
    }
}

PrintEmploys(Country.Georgia);
