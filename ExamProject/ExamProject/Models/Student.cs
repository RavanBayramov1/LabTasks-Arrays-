﻿namespace ExamProject.Models;

internal class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public Student(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
}
