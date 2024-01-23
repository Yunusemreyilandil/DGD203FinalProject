using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class Location
    {

        public string Name { get; private set; }
        public Vector2 Coordinates { get; private set; }
        public LocationType Type { get; private set; }
        public Item ItemOnLocation { get; private set; }

        private Player _player;

        private string _locationInput;



        public Location(string locationName, LocationType type, Vector2 coordinates, Item item)
        {

            Name = locationName;
            Type = type;
            Coordinates = coordinates;
            ItemOnLocation = item;
        }

        public Location(string locationName, LocationType type, Vector2 coordinates)
        {
            Name = locationName;
            Type = type;
            Coordinates = coordinates;
        }



        public void OnReached(Player player)
        {
            if (_player == null)
            {
                _player = player;
            }
            CheckLocationType();

        }

        private void CheckLocationType()
        {
            if (Type == LocationType.Clue)
            {
                OnClueReceived();
            }
            else if (Type == LocationType.NPC)
            {
                OnNpcReached();
            }
            else
            {
                OnItemReached();
            }
        }

        private void OnNpcReached()
        {
            Console.WriteLine("You reached the NPC.");
            Console.WriteLine("I'm green and small, I speak my own language.The force grows stronger with it," +
                " which jedi master am I?");


            Console.WriteLine("1-) Boba Fett");
            Console.WriteLine("2-) Asajj Ventress");
            Console.WriteLine("3-) Grogu");
            Console.WriteLine("4-) Ahsoka Tano");

            if (_player.Inventory.hasKey)
            {
                Console.WriteLine("5-) Yoda");
            }
            GetInput();

        }


        private void GetInput()
        {
            _locationInput = Console.ReadLine();

            if (_locationInput == "1")
            {
                Console.WriteLine("Wrongggggggg.Go search for the clues.");
                _player.Damage();
            }
            else if (_locationInput == "2")
            {
                Console.WriteLine("Wrongggggggg.Go search for the clues.");
                _player.Damage();
            }
            else if (_locationInput == "3")
            {
                Console.WriteLine("Wrongggggggg.Go search for the clues.");
                _player.Damage();
            }
            else if (_locationInput == "4")
            {
                Console.WriteLine("Wrongggggggg.Go search for the clues.");
                _player.Damage();
            }
            else if (_locationInput == "5" && _player.Inventory.hasKey)
            {
                Console.WriteLine("You are the mighty jedi.You defeated the riddle master.");
            }
        }


        private void OnClueReceived()
        {
            if (Name == "Clue1")
            {
                Console.WriteLine("You should search for the mighty object.");
            }

            else if (Name == "Clue2")
            {
                Console.WriteLine("There is an object that will lighten the true answer.");
            }
        }

        private void OnItemReached()
        {
            Console.WriteLine("You found the mighty object. Now you can defeat the riddle master.");

            _player.Inventory.ReceiveItem();
        }

    }

}