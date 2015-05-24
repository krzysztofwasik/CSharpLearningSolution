using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatsWebService.Models
{
    public class GameModel
    {
        public int GameId { get; set; }
        public TeamModel AwayTeam { get; set; }
        public TeamModel HomeTeam { get; set; }
        public DateTime StartTime { get; set; }

        public List<GameEventModel> Events { get; set; }
    }
}