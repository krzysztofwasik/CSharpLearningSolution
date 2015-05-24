using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;

namespace StatsWebService.DAL.Repositories
{
    public class PlayerRepository : Repository<Player>
    {
        public PlayerRepository(StatsDbContext context) : base(context)
        {
        }
    }
}