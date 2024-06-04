using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine1
{
    public class Player : LivingCreature
    {
        public int Energy { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

        public Player( int maximumHitPoints,int currentHitPoints, int energy, int experience, int level) : base (maximumHitPoints, currentHitPoints) {
        
            Energy = energy;
            Experience = experience;
            Level = level;

        }
    }
}
