using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;

namespace StatsWebService.DAL.Repositories
{
    public class TeamRepository : Repository<Team>
    {
        public TeamRepository(StatsDbContext context) : base(context)
        {
        }
    }
}