namespace RpgSaga
{
    public static class Constants
    {
        public static string[] Names = { "Жорик", "Бублик", "Шило", "Мага", "Гарри Поттер", "Терри Девис", "Бубалех", "NULL" };
        public static Dictionary<Conditions, string> StringConditions = new Dictionary<Conditions, string>()
        {
            { Conditions.IsBlind, "ослеп" },
            { Conditions.IsBurning, "горит и получает 2 единицы урона"}
        };
    } 
}
