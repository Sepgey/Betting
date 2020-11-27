using Betting.Data.Models;
using System;

namespace Betting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BettingContext())
            {
                var user = new User();
                user.Name = "Bob";
                user.Username = "Bobina";
                user.Balance = 77777;
                user.Email = "somebody@mail.ru";

                context.Users.Add(user);

                var town = new Town();
                town.Name = "Rome";

                context.Towns.Add(town);

                var team = new Team();
                team.Name = "Lacio";
                team.Budget = 1000000;
                team.Initials = "LAC";

                context.Teams.Add(team);

                var position = new Position();
                position.Name = "attack";

                context.Positions.Add(position);

                var player = new Player();
                player.Name = "Chiro";
                player.IsInjured = false;
                player.SquadNumber = 27;

                context.Players.Add(player);

                var country = new Country();
                country.Name = "Italy";

                context.Countries.Add(country);

                var game = new Game();
                game.AwayTeamBetRate = 3;
                game.HomeTeamBetRate = 2;
                game.DrawBetRate = 4;
                game.AwayTeamGoals = 7;
                game.HomeTeamGoals = 17;
                game.DateTime = DateTime.Today;

                context.Games.Add(game);

                var playerStatistic = new PlayerStatistic();
                playerStatistic.Assist = 5;
                playerStatistic.MinutesPlayed = 179;
                playerStatistic.ScoredGoals = 9;

                context.PlayerStatistics.Add(playerStatistic);

            }
        }
    }
}
