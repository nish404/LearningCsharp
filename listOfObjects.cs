using System;
using System.Collections.Generic;

namespace learningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Nish"));
            players.Add(new Player("Zenon"));
            players.Add(new Player("Athena"));

            Console.ReadKey();
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
