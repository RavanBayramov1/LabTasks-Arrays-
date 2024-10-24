namespace Student_Informations_23_10
{
    public interface IStudentService
    {
        Student[] Students { get; }
        Student GetStudentById(int id);
        Student[] GetAllStudents();
        Student[] GetStudentsByName(string name);
        void AddStudent(Student student);
        void UpdateStudent(int id);
        void RemoveStudent(int id, bool isSoftDelete);

    }
}




//Void RemoveStudent(int id, bool isSoftDelete);

//Not: RemoveStudent method-un açıqlaması - SoftDelete parametr true olduğu halda sadəcə Status Removed olacaq. Əks təqdirdə(Hard delete) bir başa olaraq Student silinəcək.
