namespace SixthConsoleApp
{
    internal class User
    {
        public string Name { get; set; } // Property
        public string Surname { get; set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; init; }

        public User() { }

        public User(string name, string lastName, string email, DateTime birthDate)
        {
            Name = name;
            Surname = lastName;
            Email = email;
            BirthDate = birthDate;
        }

        public User(string name, string lastName)
        {
            Name = name;
            Surname = lastName;
            Email = "";
            BirthDate = BirthDate;
        }

        public int getAge()
        {
            int result = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                result--;
            }
            return result;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname}, email: {Email}, {getAge()} years old");
        }
    }
}
