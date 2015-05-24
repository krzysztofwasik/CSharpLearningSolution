using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;
using StatsWebService.DAL.Repositories;

namespace StatsWebService.DAL
{
    public interface IStatsService
    {
        Repository<Game> Games { get; }
        Repository<Team> Teams { get; }
        Repository<Player> Players { get; } 
        Repository<GameEvent> Events { get; } 
    }
}