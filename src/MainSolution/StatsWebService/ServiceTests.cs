using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatsWebService.DAL;

namespace StatsWebService
{
    public class ServiceTests
    {
        // Example how to test service 
        public ServiceTests()
        {
            var service = new StatsService();

            // how to get all players from database in clean and concise way
            service.Players.Get();

            // how to get all teams from database in clean and concise way
            service.Teams.Get();
        }
    }
}