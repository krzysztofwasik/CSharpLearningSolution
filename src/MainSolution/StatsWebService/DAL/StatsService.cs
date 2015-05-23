using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;
using StatsWebService.DAL.Repositories;

namespace StatsWebService.DAL
{
    public class StatsService : IStatsService
    {
        private Repository<Game> games;
        private Repository<Team> teams;
        private Repository<Player> players;
        private Repository<GameEvent> events;


        public Repository<Game> Games 
        {
            get { return this.games ?? (this.games = new GameRepository(new StatsDbContext())); }
        }

        public Repository<Team> Teams
        {
            get { return this.teams ?? (this.teams = new TeamRepository(new StatsDbContext())); }
            
        }

        public Repository<Player> Players
        {
            get { return this.players ?? (this.players = new PlayerRepository(new StatsDbContext())); }
        }

        public Repository<GameEvent> Events
        {
            get { return this.events ?? (this.events = new EventRepository(new StatsDbContext())); }
        }
    }
}