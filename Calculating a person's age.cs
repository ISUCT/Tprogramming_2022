using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            DateTime dob = GetDOBFromUser();
            DateTime today = DateTime.Now;
            Console.WriteLine("Тестовый пример " + i + ":");
            PrintAge(dob, today);
            Console.WriteLine();
        }
    }

    static DateTime GetDOBFromUser()
    {
        Console.WriteLine("Пожалуйста, введите дату вашего рождения в формате гггг-мм-дд : ");
        DateTime dob;
        while (!DateTime.TryParse(Console.ReadLine(), out dob))
        {
            Console.WriteLine("Неверный ввод. Пожалуйста, введите действительную дату рождения в формате yyyy-mm-dd : ");
        }
        return dob;
    }

    static void PrintAge(DateTime dob, DateTime today)
    {
        TimeSpan ageSpan = today - dob;
        int years = (int)(ageSpan.TotalDays / 365.25);
        int months = (int)(ageSpan.TotalDays / 30.44);
        int days = (int)ageSpan.TotalDays;

        Console.WriteLine("возраст: {0} лет, {1} месяцев, {2} дней", years, months, days);
    }
}
