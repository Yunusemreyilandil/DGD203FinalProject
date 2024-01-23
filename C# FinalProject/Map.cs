using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class Map
    {
        public Location[] _locations;

        public void GenerateLocations()
        {
            _locations = new Location[4];

            Vector2 deskLocation = new Vector2(3, 3);
            Item desklItem = Item.Key;

            Location gristol = new Location("Desk", LocationType.ClueObject, deskLocation, desklItem);
            _locations[0] = gristol;

            Vector2 npcLocation = new Vector2(1, 1);
            Location npc = new Location("NPC", LocationType.NPC, npcLocation);
            _locations[1] = npc;

            Vector2 clue1Location = new Vector2(-1, -1);
            Location clue1 = new Location("Clue1", LocationType.Clue, clue1Location);
            _locations[2] = clue1;

            Vector2 clue2Location = new Vector2(-4, 0);
            Location clue2 = new Location("Clue2", LocationType.Clue, clue2Location);
            _locations[3] = clue2;
        }
    }
}