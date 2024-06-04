using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine1
{
    public class LivingCreature
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }

        public LivingCreature(int maxHP, int currentHP)
        {
            MaxHP = maxHP;
            CurrentHP = currentHP;
        }
    }
}
