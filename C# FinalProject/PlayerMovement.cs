using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class PlayerMovement
    {
        public Player Player { get; set; }
        public Map Map { get; set; }

        private Vector2 _coordinates;

        public void MovePlayer(int x, int y)
        {
            int newXCoordinate = (int)_coordinates.X + x;
            int newYCoordinate = (int)_coordinates.Y + y;


            _coordinates.X = newXCoordinate;
            _coordinates.Y = newYCoordinate;

            Console.WriteLine(_coordinates);
            CheckForLocation(_coordinates);
        }

        public void CheckForLocation(Vector2 coordinates)
        {
            foreach (var point in Map._locations)
            {
                if (point.Coordinates == coordinates)
                {
                    point.OnReached(Player);
                }
            }
        }
    }
}