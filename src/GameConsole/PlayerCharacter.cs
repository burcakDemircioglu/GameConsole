using System;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public PlayerCharacter(String name, SpecialDefence specialDefence)
        {
            Name = name;
            _specialDefence = specialDefence;
        }

        public int Health { get; set; } = 100;

        public string Name { get; set; }

        public int? DaysSinceLastLogin { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? IsNoob { get; set; }

        public void Hit(int damage)
        {
            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);
            Health -= totalDamageTaken;
            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
    }
}
