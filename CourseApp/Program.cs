using System;
using CourseApp;

public class Program
{
        public static void Main(string[] args)
        {
            Person person = new Person(45);
            person.Height = 176;
            person.Weight = 74;
            person.Show();
            System.Console.WriteLine();
            Person person1 = new Person(20, 177, 99);
            person1.Show();
            System.Console.WriteLine("Based on the results of the entered data");
            person1.Midlle_Age();
            person1.Average_Height();
            person1.Average_Weight();
        }
}