using System.Xml.Linq;

namespace Student_Informations_23_10
{
    public class StudentService : IStudentService
    {
        private Student[] _students; 
        public Student[] Students
        {
            get { return _students; }
        }

        public StudentService(Student[] students)
        {
            _students = students;
        }
        //Student[] IStudentService.Students => throw new NotImplementedException();

        public Student GetStudentById(int id)
        {
            for (int i = 0; i < Students.Length;i++) 
            {
                if(Students[i].Id == id)
                return Students[i];
            }
            return null;
        }
        public Student[] GetAllStudents()
        {   
            return Students;
        }

        public Student[] GetStudentsByName(string name)
        {
            Student[] students = new Student[0];
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].FirstName == name)
                {
                    Array.Resize(ref students, students.Length+1);
                    students[^1]= Students[i];
                }
            }
            return students;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[^1] = student;
        }

        public void UpdateStudent(int id)
        {
            for(int i = 0; i < _students.Length; i++)
            {
                if(_students[i].Id == id)
                {
                    Console.WriteLine("Adi daxil edin: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Soyadi daxil edin: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Emaili daxil edin: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Telefon nomresini daxil edin: ");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("GPA-i daxil edin: ");
                    double gpa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ixtisasi daxil edin: ");
                    string major = Console.ReadLine();
                    Students[i].FirstName = firstName;
                    Students[i].LastName = lastName;
                    Students[i].Email = email;
                    Students[i].PhoneNumber = phoneNumber;
                    Students[i].GPA = gpa;
                    Students[i].Major = major;
                    Students[i].StudentStatus = StudentStatus.Pending;
                }
            }    
        }

        public void RemoveStudent(int id, bool isSoftDelete)
        {
            if (isSoftDelete)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Id == id)
                    {
                        Students[i].StudentStatus = StudentStatus.Removed;
                        return ;
                    }
                }
                 
            }
            for(int j = 0; j < Students.Length; j++)
            {
                if(Students[j].Id == id)
                {
                    Student[] students2 = new Student[Students.Length-1];
                    bool flag = true;
                    for (int i = 0; i < Students.Length; i++)
                    {
                        if(Students[i].Id != id && flag)
                        {
                            students2[i] = Students[i];

                            // 0 1 2 3 4 5
                            // 0 1 0 3 4
                        }
                        else if (Students[i].Id == id)
                        {
                            students2[i] = Students[i+1];
                            flag = false;
                        }
                    }
                    _students = students2;
                    return;
                }
                
            }
            Console.WriteLine("Ay Qardas bu adamin tanisi var, yuxaridan tapsirilib istirak etmir");
        }
    }
}
