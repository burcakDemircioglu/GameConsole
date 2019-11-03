using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Burcak";
            player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
