﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class HourlyEmployee : Employee
    {
        public double HourlyRate;
        public double HourlyWorked;
        public HourlyEmployee(string name, string surname, int age ,double hourlyRate, double hourlyWorked) : base(name, surname, age)
        {
            HourlyRate = hourlyRate;
            HourlyWorked =hourlyWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HourlyWorked;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Saatliq gelir: " + HourlyRate);
            Console.WriteLine("Is saati: " + HourlyWorked);
        }
    }
}


/*
1. Employee Abstract class'ı yaranacaq.

1.1 Özəllikləri(Properties):
Id = int type, Employee object'in Idsi saxlanılacaq
Name - string type, Employee object'in adı saxlanılacaq
Surname - string type, Employee object'in soyadı saxlanılacaq
Age - int type, Employee object'in yaşı saxlanılacaq

NOT: Id bizim tərəfimizdən daxil edilməməli, hər dəfə Employee'dan miras alan class'ın instace'ı alınan zaman avtomatik olaraq özü arxa tərəfdə Id-ə mənimsədilməlidir. Lakin bilməli olduğumuz məqam Id hər bir object üçün unique olmalıdır. Bu da deməkdir ki Id property readonly olmalıdır. Və static olaraq artan bir counter field'a ehtiyyacımız olacaq.

1.2 Davranış(Methods):

abstract double CalculateSalary() - Hər bir object üçün aldığı maaşı hesablamalıdır.
abstract void DisplayDetails() - Hər bir object'in haqqındaki məlumatları ekrana çıxarılmalıdır.

2. Employee Class'dan miras alan 2 class mövcud olmalıdır. HourlyEmployee və SalariedEmployee

3.1 HourlyEmployee

3.2 Özəllikləri:
HourlyRate - dobule type, HourlyEmployee object'in saatlıq qazancı saxlanılacaq.
HoursWorked - double type, HourlyEMployee object'in aylıq çalışdığı saat saxlanılacaq.

3.3 Davranış:

double CalculateSalary() - override edilməlidir və method HourlyEmployee'un saatlıq qazancını * aylıq işlədiyi saata vurub geri qaytarmalıdır.

void DisplayDetails() - override edilməlidir və method HourlyEmployee'un haqqındaki məlumatları ekrana çıxarmalıdır.

4.1 SalariedEmployee

4.2 Özəllikləri:

MonthlySalary - double type, SalariedEmployee object'in aylıq qazancını saxlayacaq.

4.3 Davranışı:

double CalculateSalary() - override edilməlidir və method SalariedEmployee'un aylıq qazancını geri qaytarmalıdır.

void DisplayDetails() - override edilməlidir və method SalariedEmployee'un haqqındaki məlumatları ekrana çıxarmalıdır.

5. Program.cs daxilində hər iki class'a uyğun object alınmalı və hər bir method çalıştırılmalıdır.


*/