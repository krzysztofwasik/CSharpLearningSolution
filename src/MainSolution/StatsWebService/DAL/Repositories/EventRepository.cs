using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL.Entities;

namespace StatsWebService.DAL.Repositories
{
    public class EventRepository : Repository<GameEvent>
    {
        public EventRepository(StatsDbContext context) : base(context)
        {
        }
    }
}