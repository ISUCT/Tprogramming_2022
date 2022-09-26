using System;
using CourseApp;

public class Program
{
        public static void Main(string[] args)
        {
            Person person = new Person(20, 177, 99);
            person.Show();
            System.Console.WriteLine("Based on the results of the entered data");
            person.Midlle_Age();
            person.Average_Height();
            person.Average_Weight();
        }
}