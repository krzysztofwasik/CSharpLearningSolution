using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;

namespace StatsWebService.DAL.Repositories
{
    public class GameRepository : Repository<Game>
    {
        public GameRepository(StatsDbContext context) : base(context)
        {
        }
    }
}