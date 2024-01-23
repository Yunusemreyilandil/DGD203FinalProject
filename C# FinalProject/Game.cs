using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class Game
    {
        private string _playerInput;
        public bool _isGameRunning;
        public Map map;

        public Player Player { get; private set; }
        private string _playerName;

        public void StartGame(Game instance)
        {
            CreateMap();

            CreatePlayer();

            _isGameRunning = true;
            StartGameLoop();
        }

        private void CreateMap()
        {
            map = new Map();
            map.GenerateLocations();
        }

        private void CreatePlayer()
        {
            Player = new Player(map);

            if (_playerName == null)
            {
                GetPlayerName();
            }
        }

        private void GetPlayerName()
        {
            Console.WriteLine("Welcome to the Ilum!");
            Console.WriteLine("Would you be kind enough to provide us with your name?");
            _playerName = Console.ReadLine();

            if (_playerName == "")
            {
                Console.WriteLine("You didn't enter a player name, giving the name Anakin Skywalker");
                _playerName = "Anakin Skywalker";
            }
            else
            {
                Console.WriteLine($"Nice to meet you {_playerName}!");
            }
            Player.SetCodeName(_playerName);
        }

        private void StartGameLoop()
        {
            while (_isGameRunning)
            {
                GetInput();
                ReadInput();
            }

        }

        private void ReadInput()
        {
            if (_playerInput == "" || _playerInput == null)
            {
                Console.WriteLine("Give me a command!");
                return;
            }

            switch (_playerInput)
            {
                case "W":
                    Player.PlayerMovement.MovePlayer(0, 1);
                    break;
                case "S":
                    Player.PlayerMovement.MovePlayer(0, -1);
                    break;
                case "D":
                    Player.PlayerMovement.MovePlayer(1, 0);
                    break;
                case "A":
                    Player.PlayerMovement.MovePlayer(-1, 0);
                    break;
                case "exit":
                    Console.WriteLine("We hope you enjoyed our game!");
                    _isGameRunning = false;
                    Environment.Exit(0);
                    break;
                case "help":
                    Console.WriteLine(HelpMessage());
                    break;
                case "clear":
                    Console.Clear();
                    break;
                case "who":
                    Console.WriteLine($"You are {Player.CodeName}, the mighty hero of the Isles");
                    break;
                case "I":
                    Player.CheckInventory();
                    break;
                default:
                    Console.WriteLine("Command not recognized. Please type 'help' for a list of available commands");
                    break;
            }

        }

        private void GetInput()
        {
            _playerInput = Console.ReadLine();
        }


        private string HelpMessage()
        {
            return @"Here are the current inputs. Don't forget your caps lock:
W: go north
S: go south
D: go west
A: go east
exit: exit the game";

        }
    }
}
