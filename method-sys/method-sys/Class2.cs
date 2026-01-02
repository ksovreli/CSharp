

using System;

namespace SixthConsoleApp
{
    internal class StudentClass
    {
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthDate { get; init; }
        public int studentId { get; set; }  
        public int groupId { get; set; }

        public StudentClass(string user, string lastname, DateTime BirthDate, int StudentId, int GroupId)
        {
            name = user;
            surname = lastname;
            birthDate = BirthDate;
            studentId = StudentId;
            groupId = GroupId;
        }

        public void Print()
        {
            Console.WriteLine($"{name} {surname} {birthDate} studentId: {studentId} groupId {groupId}");
        }

        public StudentClass(){ }

    }
}
