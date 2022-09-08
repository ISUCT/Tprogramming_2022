using System;
using CourseApp;

public class Program
{
        public static void Main(string[] args)
        {
            Person person = new Person(45);
            person.Height = 177;
            person.Weight = 74;
            person.Show();
            System.Console.WriteLine("Based on the results of the entered data");
            person.Midlle_Age();
            person.Average_Height();
            person.Average_Weight();
            System.Console.WriteLine();
            Person person1 = new Person(20, 190, 91);
            person1.Show();
        }
}