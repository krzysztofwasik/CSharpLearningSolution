using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StatsWebService.DAL;
using StatsWebService.Filters;
using StatsWebService.Models;

namespace StatsWebService.Controllers
{
    public class TeamController : BaseApiController
    {
        public TeamController() : base(new StatsService(), new ModelFactory())
        {
        }

        public IHttpActionResult Get()
        {
            try
            {
                var teams = StatsService.Teams.Get();
                var models = teams.Select(ModelFactory.Create);

                return Ok(models);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex); 
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var team = StatsService.Teams.Get(id);
                var model = ModelFactory.Create(team);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex); 
            }
        }

        [ModelValidator] // Attribute that say that this method has filter validation by class which derives from ActionFilterAttribute
        public IHttpActionResult Post([FromBody] PlayerModel teamModel)
        {

            var teamEntity = ModelFactory.Create(teamModel);
            var team = StatsService.Players.Insert(teamEntity);
            var model = ModelFactory.Create(team);

            return Created(string.Format("http://localhost:60006/api/player/{0}", model.PlayerId), model);
        }
    }
}
