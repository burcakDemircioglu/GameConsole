using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter sarah = new PlayerCharacter("Sarah", new DiamondSkinDefence());

            PlayerCharacter amrit = new PlayerCharacter("Amrit", new IronBonesdefence());

            PlayerCharacter gentry = new PlayerCharacter("Gentry", SpecialDefence.Null);

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();
        }
    }
}
