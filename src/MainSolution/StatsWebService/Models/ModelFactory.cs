using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;

namespace StatsWebService.Models
{
    public interface IModelFactory
    {
        PlayerModel Create(Player player);
        Player Create(PlayerModel playerModel);
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
                TeamName = player.Team !=null ? player.Team.Name : null
            };
        }


        public Player Create(PlayerModel playerModel)
        {
            return new Player
            {
                FirstName = playerModel.FirstName,
                LastName = playerModel.LastName,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };
        }
    }
}