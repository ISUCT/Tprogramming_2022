namespace RpgSaga
{
    public static class Constants
    {
        public static string[] Names = { "Санёчек", "Данёчек", "Владосик", "Лёха", "Гарри Поттер", "Терри Девис", "Папа Римский", "NULL" };
        public static Dictionary<Conditions, string> StringConditions = new Dictionary<Conditions, string>()
        {
            { Conditions.IsBlind, "ослеп" },
            { Conditions.IsBurning, "горит и получает 2 единицы урона"}
        };
    } 
}
