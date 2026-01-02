using EighthConsoleApp.Enums;

namespace EighthConsoleApp.Models
{
    internal class Employ
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Salary { get; set; }
        public Country Country { get; set; }
        public Gender Gender { get; set; }
        public Contacts Contacts { get; set; }


        public Employ(string Name, string Surname, string JobTitle, DateTime DateOfBirth, uint Salary, Country Country, Gender Gender, Contacts Contacts)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.JobTitle = JobTitle;
            this.DateOfBirth = DateOfBirth;
            this.Salary = Salary;
            this.Country = Country;
            this.Gender = Gender;
            this.Contacts = Contacts;
        }


        public int GetAge()
        {
            int result = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                result--;
            }
            return result;
        }

        public void Print()
        {
            Console.WriteLine(
                $"\n\t{Name} {Surname}" +
                $"\n\tAge: {GetAge()}" +
                $"\n\tJob Title: {JobTitle}" +
                $"\n\tDate of Birth: {DateOfBirth}" +
                $"\n\tSalary {Salary}$" +
                $"\n\tCountry: {Country}" +
                $"\n\tGender: {Gender}" +
                $"\n\tContacts: {Contacts}"
            );
        }
    }
}
