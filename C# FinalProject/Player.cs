using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class Player
    {
        private readonly int _maxHealth = 10;
        public int Health { get; private set; }
        public string CodeName { get; private set; }
        public PlayerMovement PlayerMovement { get; private set; }
        public Inventory Inventory { get; private set; }
        public void SetCodeName(string codeName)
        {
            CodeName = codeName;
        }
        public Player(Map map)
        {
            Health = _maxHealth;
            PlayerMovement = new PlayerMovement();
            PlayerMovement.Map = map;
            PlayerMovement.Player = this;
            Inventory = new Inventory();
        }

        public void Damage()
        {
            Health -= 5;

            if( Health <= 0)
            {
                Die();
            }

        }

        private void Die()
        {
            Console.WriteLine("You are death");
            Environment.Exit(0);
        }

        public bool CheckInventory()
        {
            if (Inventory.hasKey)
            {
                Console.WriteLine("You have the mighty object.");
            }
            else
            {
                Console.WriteLine("You don't have the mighty object.");
            }
            return Inventory.hasKey;
        }
    }
}