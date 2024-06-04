using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine1
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int mindam, int maxdam) : base(id, name, namePlural)
        {
            MinimumDamage = mindam;
            MaximumDamage = maxdam;
        }
    }
}