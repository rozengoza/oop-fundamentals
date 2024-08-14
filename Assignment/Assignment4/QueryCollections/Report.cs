
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trainee;

namespace reports
{
    internal class Reports
    {
        static List<Trainee> trainees = [
        new("Ram Bista", new DateTime(1990, 12, 12), "Vedas", "BIT"),
        new("Laxman Shrestha", new DateTime(1988, 1, 10), "Ascol", "BSC"),
        new("Bishnu Rawal", new DateTime(1990, 4, 22), "PK", "BIM"),
        new("Suneer Bista", new DateTime(2000, 6, 10), "Cenral TU", "BIT"),
        new("Sita Acharya", new DateTime(2010, 8, 29), "CCRC", "BIT"),
        new("Ram Basnet", new DateTime(2004, 9, 23), "People's College", "BSC"),
        new("Rama Chitrakar", new DateTime(2003, 8, 17), "People's College", "BSC"),
        new("Mahesh Manandhar", new DateTime(2004, 9, 23), "CCRC", "BIM"),
        new("Renu Shahi", new DateTime(2004, 9, 23), "Vedas", "BIM"),
        new("Sanjana Luitel", new DateTime(2007, 4, 26), "PK", "BSC")
    ];

       public static void LetsQuery()
        {
            // Get all trainees grouped by their college
            var traineesGroupedByCollege = trainees.Select(x => new {Name = x.name, College = x.college}).GroupBy(x => x.College);
            foreach(var trainee in traineesGroupedByCollege)
            {
                foreach(var traineeUnit in trainee)
                {
                    Console.WriteLine($"{traineeUnit.Name} {traineeUnit.College}");
                }
            }

            //Get name and age f  trainees who are on their teens
            var traineesByAge = trainees.Where(x => x.CalculateAge().Item2 /365 < 19 ).Select(x => new { Name = x.name, Age = x.CalculateAge() });
            foreach (var trainee in traineesByAge)
            {
                Console.WriteLine($"{trainee.Name} {trainee.Age.Item1}");
               /* var traineeAgeInDays = trainee.Age.Item2;
                if(traineeAgeInDays / 365 < 19 )
                {
                    Console.WriteLine($"{trainee.Name} {trainee.Age.Item1}");
                }*/
            }

            //Get name initial, age, academic program of trainees and  order result by initials

            var traineesByAcademics = trainees.Select(x => new { Name = x.name, Age = x.CalculateAge().Item1, Program = x.program, Initials = x.GetInitials() }).OrderBy(x => x.Initials);
            foreach (var trainee in traineesByAcademics)
            {
                Console.WriteLine($"{trainee.Name} {trainee.Age} {trainee.Program}");
            }
        }
    }
}