namespace Class_MethodsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Grade[] grds = [
                new Grade(96,"Math",4),
                new Grade(90,"History",4),
                new Grade(85,"Chemistry", 4),
                new Grade(76,"Physics", 4)
                ];
                Student ravan = new Student();
                ravan.Grades = grds;

                Console.WriteLine(ravan.GetAvgGrade());
        }
    }
}
