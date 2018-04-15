using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatedFootballTeam
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split(';');
                switch (commandArgs[0])
                {
                    case "Team":
                        AddTeam(teams, commandArgs);
                        break;
                    case "Add":
                        AddPlayer(teams, commandArgs);
                        break;
                    case "Remove":
                        RemovePlayer(teams, commandArgs);
                        break;

                    case "Rating":
                        TeamRating(teams, commandArgs);
                        break;

                }
                command = Console.ReadLine();
            }
        }

        private static void TeamRating(Dictionary<string, Team> teams, string[] commandArgs)
        {
            Console.WriteLine($"{commandArgs[1]} - {teams[commandArgs[1]].Rating}");
        }

        private static void RemovePlayer(Dictionary<string, Team> teams, string[] commandArgs)
        {
            if (teams.ContainsKey(commandArgs[1]))
            {
                Console.WriteLine($"Team {commandArgs[1]} doesn not exists.");
                return;
            }
            try
            {
                teams[commandArgs[1]].RemovePlayer(commandArgs[2]);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddPlayer(Dictionary<string, Team> teams, string[] commandArgs)
        {
            Player player = null;
            try

            {
                player = new Player(commandArgs[2],
                    int.Parse(commandArgs[3]),
                    int.Parse(commandArgs[4]),
                    int.Parse(commandArgs[5]),
                    int.Parse(commandArgs[6]),
                    int.Parse(commandArgs[7]));

                if (teams.ContainsKey(commandArgs[1]))
                {
                    Console.WriteLine($"Team {commandArgs[1]} doesn not exists.");
                }
                teams[commandArgs[1]].AddPlayer(player);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }

        private static void AddTeam(Dictionary<string, Team> teams, string[] commandArgs)
        {
            if (teams.ContainsKey(commandArgs[1]))
            {
                Console.WriteLine("Team already exists!");
                return;
            }
            teams.Add(commandArgs[1], new Team(commandArgs[1]));
        }
    }
}
