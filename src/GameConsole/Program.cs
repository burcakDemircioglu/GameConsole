using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();
            player.DaysSinceLastLogin = 42;

            int days = player?.DaysSinceLastLogin ?? -1;
            Console.WriteLine(days);

            // PlayerDisplayer.Write(player);

            PlayerCharacter[] players = new PlayerCharacter[3]
            {
               new PlayerCharacter{Name="Burcak"},
               new PlayerCharacter(),
               null
            };

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            Console.WriteLine(p1 + " " + p2 + " " + p3);
            Console.ReadLine();
        }
    }
}
