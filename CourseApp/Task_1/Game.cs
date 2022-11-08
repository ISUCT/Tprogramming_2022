namespace CourseApp.Task_1
{
    using System;

    public class Game
    {
        public static void Start()
        {
            Pistol gun = new Pistol("semi-auto", "colt1911", 7);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(gun.Info());
            Console.ResetColor();
            if (CheckWantEdit())
            {
                Console.WriteLine("Enter, separated by a space, the type of shooting, the name of pistol and the maximum count of ammo in the magazine");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Example: ");
                Console.ResetColor();
                Console.WriteLine("auto glock18 33");
                string[] splitedbuf = CheckEdit();
                gun.ShootingType = splitedbuf[0];
                gun.Name = splitedbuf[1];
                gun.MaxAmmo = int.Parse(splitedbuf[2]);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Use ");
            Console.ResetColor();
            Console.Write("Enter");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" button for shoot, insert ");
            Console.ResetColor();
            Console.Write("r");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" in console for reload, insert ");
            Console.ResetColor();
            Console.Write("q");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" for quit");
            Console.ResetColor();
            Actions(gun);
        }

        public static void Actions(Pistol gun)
        {
            for (; ;)
            {
                string action = Console.ReadLine();
                if (string.IsNullOrEmpty(action))
                {
                    if (!gun.Shoot())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("RELOAD IMMEDIATELY!!!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("BANG!");
                        Console.ResetColor();
                    }
                }
                else if (action == "r")
                {
                    if (gun.Reload())
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Your pistol reloaded!");
                        Console.ResetColor();
                    }
                }
                else if (action == "q")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Incorrect action, try again");
                    Console.ResetColor();
                }
            }
        }

        public static bool CheckWantEdit()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Do you want to edit the pistol?");
            Console.WriteLine("Write y(yes) or n(no)");
            Console.ResetColor();
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string[] CheckEdit()
        {
            for (; ;)
            {
                string buffer = Console.ReadLine();
                string[] splitedbuf = buffer.Split(" ");
                if (splitedbuf.Length != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect input, try again!");
                    Console.ResetColor();
                }
                else
                {
                    if (int.TryParse(splitedbuf[2], out var number))
                    {
                        if (number < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect max ammo, use numbers more then 0, try again!");
                            Console.ResetColor();
                        }
                        else
                        {
                            return splitedbuf;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect max ammo, use numbers!");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}