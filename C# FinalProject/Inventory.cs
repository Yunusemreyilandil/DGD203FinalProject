using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class Inventory
    {
        public bool hasKey { get; private set; }

        public void ReceiveItem()
        {
            hasKey = true;
        }

        public void RemoveItem()
        {
            hasKey = false;
        }
    }
}