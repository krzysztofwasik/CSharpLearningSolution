using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;
using StatsWebService.DAL.Entities;

namespace StatsWebService.Models
{
    public interface IModelFactory
    {
        PlayerModel Create(Player player);
        Player Create(PlayerModel playerModel);
        TeamModel Create(Team team);
        Team Create(TeamModel teamModel);
        GameModel Create(Game game);
        GameEventModel Create(GameEvent gameEvent);
        GameEvent Create(Game game, Player player, int pointValue);

    }

    public class ModelFactory : IModelFactory
    {
        public PlayerModel Create(Player player)
        {
            return new PlayerModel
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                PlayerId = player.Id,
                TeamId = player.Team !=null ? player.Team.Id : 0,
                TeamName = player.Team !=null ? player.Team.Name : null,
            };
        }


        public Player Create(PlayerModel playerModel)
        {
            if (playerModel.PlayerId == 0)
            {
                return new Player
                {
                    FirstName = playerModel.FirstName,
                    LastName = playerModel.LastName,
                    UpdatedDate = DateTime.Now
                };
            }

            return new Player
            {
                Id = playerModel.PlayerId,
                FirstName = playerModel.FirstName,
                LastName = playerModel.LastName,
                UpdatedDate = DateTime.Now
                
            };
        }


        public TeamModel Create(Team team)
        {
            return new TeamModel
            {
                TeamId = team.Id,
                TeamName = team.Name,
                Players = new List<PlayerModel>(team.Players.Select(Create))
            };

        }

        public Team Create(TeamModel teamModel)
        {
            return new Team
            {
                Id = teamModel.TeamId,
                Name = teamModel.TeamName,
                Players = new List<Player>(teamModel.Players.Select(Create)),
                UpdatedDate = DateTime.Now
            };
        }

        public GameModel Create(Game game)
        {
            return new GameModel
            {
                AwayTeam = Create(game.AwayTeam),
                HomeTeam = Create(game.HomeTeam),
                Events = game.Events.Select(Create).ToList(),
                GameId = game.Id,
                StartTime = game.StartTime
            };
        }


        public GameEventModel Create(GameEvent gameEvent)
        {
            return new GameEventModel
            {
                GameId = gameEvent.Id,
                PlayerId = gameEvent.Player.Id,
                PointValue = gameEvent.PointValue
            };
        }


        public GameEvent Create(Game game, Player player, int pointValue)
        {
            return new GameEvent
            {
                Game = game,
                Player = player,
                PointValue = pointValue,
                UpdatedDate = DateTime.Now
            };
        }
    }
}