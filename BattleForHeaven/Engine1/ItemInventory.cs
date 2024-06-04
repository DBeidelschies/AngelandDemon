using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine1
{
    public class ItemInventory
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }
        public ItemInventory(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
