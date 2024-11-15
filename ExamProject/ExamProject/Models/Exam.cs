namespace ExamProject.Models;

internal class Exam
{
        public Student Student { get; set; }
        public int Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Exam(Student student, int point, string subject, DateTime startDate, DateTime endDate)
        {
            Student = student;
            Point = point;
            Subject = subject;
            StartDate = startDate;
            EndDate = endDate;
        }
    }

