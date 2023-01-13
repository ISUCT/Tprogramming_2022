using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Test case " + i + ":");
            DateTime dob = GetDOBFromUser();
            DateTime today = DateTime.Now;
            PrintAge(dob, today);
            Console.WriteLine();
        }
    }

    static DateTime GetDOBFromUser()
    {
        DateTime dob;
        while (true)
        {
            Console.WriteLine("Пожалуйста, введите дату вашего рождения в формате гггг-мм-дд: ");
            if (DateTime.TryParse(Console.ReadLine(), out dob))
            {
                break;
            }
            Console.WriteLine("Неверный Ввод. Пожалуйста, введите действительную дату рождения в формате гггг-мм-дд: ");
        }
        return dob;
    }

    static void PrintAge(DateTime dob, DateTime today)
    {
        TimeSpan age = today - dob;
        int years = (int)(age.TotalDays / 365.25);
        int months = (int)(age.TotalDays / 30.44);
        int days = (int)age.TotalDays;

        Console.WriteLine("Возраст: {0} лет, {1} месяцев, {2} дней", years, months, days);
    }
}
