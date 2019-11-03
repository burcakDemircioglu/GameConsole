using System;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly ISpecialDefence _specialDefence;

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public int Health { get; set; } = 100;

        public string Name { get; set; }

        // public Nullable<int> DaysSinceLastLogin { get; set; }
        public int? DaysSinceLastLogin { get; set; }

        // public Nullable<DateTime> DateOfBirth { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool? IsNoob { get; set; }

        public void Hit(int damage)
        {
            // int damageReduction = 0;

            // if (_specialDefence != null)
            // {
            //     damageReduction = _specialDefence.CalculateDamageReduction(damage);
            // }

            // int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;
            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
    }
}
