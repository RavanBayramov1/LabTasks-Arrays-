namespace Student_Informations_23_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ravan = new Student("Ravan","Bayramov","ravanbayramov@gmail.com","070 314 16 66",100,"Computer Engineering");
            Student farid = new Student("Farid", "Najafov", "faridnajafov@gmail.com", "077 368 30 10", 98.5, "Computer Engineering");
            Student murad = new Student("Murad", "Cavadov", "muradcavadov@gmail.com", "077 306 93 97", 99.1, "Computer Science");
            Student huseyn = new Student("Huseyn", "Eyvazli", "huseyneyvazli@gmail.com", "077 306 93 97", 99.1, "Computer Science");
            Student[] Students = { ravan, farid, murad };

            IStudentService studentService = new StudentService(Students);
            studentService.AddStudent(huseyn);
            //studentService.GetAllStudents();
            Student[] students = studentService.GetAllStudents();
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
