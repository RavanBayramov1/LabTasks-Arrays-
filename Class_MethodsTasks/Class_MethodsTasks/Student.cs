namespace Class_MethodsTasks
{
    public class Student
    {
        public string Name;
        public string Surname;
        public Grade[] Grades;


        public float GetAvgGrade()
        {
            float sum = 0;
            for (int i = 0; i<Grades.Length ; i++) 
            {
                sum += Grades[i].Point;
            }
            return sum/Grades.Length;
        }
        public int GetCreditCount()
        {
            int sum = 0;
            foreach (var grd in Grades)
            {
                sum += grd.CreditCount;
            }
            return sum;
        }
    }
}
