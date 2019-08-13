using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Science");
            book.AddGrade(89.1);
            var sum=0.0;
            List<double> grades=new List<double>() {24.5,67.8};
            foreach(var grade in grades){
                sum+=grade;
            }
            var average=sum/grades.Count;
            System.Console.WriteLine($"{average:N3}");
            //Console.WriteLine($"Hello {args[0]}!");
        }
    }
}
