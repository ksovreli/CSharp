namespace SeventhConsoleApp
{
    internal class Lector // დავალება 1
    {
        private string Name { get; init; }
        private string Surname { get; init; }


        public Lector() { }

        public Lector(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }

    internal class Student // დავალება 2
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public DateTime BirthDate { get; set; }
        public int StudentId { get; set; }
        public int GroupId { get; set; }

        public Student() { }

        public Student(string name, string surname, DateTime birthdate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
        }

        public Student(string name, string surname, DateTime birthdate, int studentid, int groupid)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            StudentId = studentid;
            GroupId = groupid;
        }

        public int getAge()
        {
            int result = DateTime.Now.Year - BirthDate.Year;
            if(DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                result--;
            }
            return result;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {getAge()} years old. {BirthDate} SID: {StudentId} GID: {GroupId}");
        }
    }
}
