using ExamProject.Extentions;
using ExamProject.Models;

namespace ExamProject;

 class Program
{
    static void Main(string[] args)
    {
        List<Exam> exams = [
            new Exam(new Student("Ravan" , "Bayramov") , 100 , ("Math") , new DateTime(2024,10,30,08,00,00),new DateTime(2024,10,30,10,00,00)),
            new Exam(new Student("Farid" , "Najafov") , 95 , ("Math") , new DateTime(2024,10,30,08,00,00),new DateTime(2024,10,30,09,00,00)),
            new Exam(new Student("Talib" , "Abilov") , 99, ("Math") , new DateTime(2024,10,30,08,00,00),new DateTime(2024,10,21,08,30,00)),
        ];

        //exams.FindAll(x => x.Point > 50).PrintExam();
        //exams.FindAll(x => DateTime.Now.AddDays(-7) < x.StartDate).PrintExam();
        static bool GetExamsLongerThan1Hour(Exam x)
        {
            return (x.EndDate - x.StartDate).TotalHours >= 1;
        }
    }
}