﻿using ExamProject.Models;

namespace ExamProject.Extentions;

static class ListExtensions 
{
    public static void PrintExam(this List<Exam> list)
    {
        list.ForEach(item => Console.WriteLine($"{item.Student.Name+ " " + item.Student.Surname + ": "} {item.Subject} {item.Point} {(item.EndDate - item.StartDate)}"));
    }
}

