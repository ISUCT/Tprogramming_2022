namespace RpgSaga
{
    public class PlayerLogger : ILogger
    {
        public void ShowName(string name)
        {
            System.Console.WriteLine(name);
        }

        public void EnterTheNumberOfPlayers()
        {
            Console.WriteLine("Введите четное число игроков");
        }

        public void NumberIsEvenWarning()
        {
            Console.WriteLine("Число игроков должно быть четным");
        }
    }
}
