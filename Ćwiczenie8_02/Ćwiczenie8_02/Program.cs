using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie8_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        struct Student
        {
            public int StudentId;
            public string FirstName;
            public string LastName;
            public int Age;
            public string Major;
        }
        struct Subject
        {
            public int SubjectId;
            public string Name;
            public string Major;
            public int DifficultyLevel;
        }
        struct AcademicTeacher
        {
            public int TeacherId;
            public string FirstName;
            public string LastName;
            public string AcademicTitle;
        }
    }
}
