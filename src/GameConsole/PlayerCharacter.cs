using System;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }

        // public Nullable<int> DaysSinceLastLogin { get; set; }
        public int? DaysSinceLastLogin { get; set; }

        // public Nullable<DateTime> DateOfBirth { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool? IsNoob { get; set; }
    }
}
