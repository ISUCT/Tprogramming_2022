namespace RpgSaga
{
    public class PlayerSystem
    {
        public int EnterNumberOfPlayers()
        {
            Console.WriteLine("Enter the even number of players");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0 && number > 0)
                {
                    return number;
                }
            }
            
            Console.WriteLine("The number of players must be even integer");
            return 0;
        }

        public Player CreatePlayer(int number)
        {
            if (number % 3 == 0)
            {
                return new Wheelchair();
            }
            if (number % 3 == 1)
            {
                return new ChupaChups();
            }

            return new Baranka();
        }
    }
}
