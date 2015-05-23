using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using StatsWebService.DAL;
using StatsWebService.DAL.Entities;
using StatsWebService.Models;

namespace StatsWebService.Controllers
{
    public class PlayerController : ApiController
    {
        private IStatsService service;
        private IModelFactory modelFactory;

        public PlayerController()
        {
            this.service = new StatsService();
            this.modelFactory = new ModelFactory();
        }

        public IHttpActionResult Get()
        {
            try
            {
                var players = this.service.Players.Get();
                var models = players.Select(this.modelFactory.Create);

                return Ok(models);
            }
            catch (Exception ex)
            {
                // Logging
#if DEBUG
                return InternalServerError(ex); // For security purpose do not send entire error message to user
#endif
                return InternalServerError();
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var player = this.service.Players.Get(id);
                var model = this.modelFactory.Create(player);
                return Ok(model);
            }
            catch (Exception ex)
            {
                // Logging
#if DEBUG
                return InternalServerError(ex); // For security purpose do not send entire error message to user
#endif
                return InternalServerError();
            }
        }

        public IHttpActionResult Post([FromBody] PlayerModel playerModel)
        {
            var playerEntity = this.modelFactory.Create(playerModel);
            var player = this.service.Players.Insert(playerEntity);

            // it is bad idea to pass entity to output because of recursion problems in serialization
            // so we have to pass model based on entity
            var model = this.modelFactory.Create(player);

            return Created(string.Format("http://localhost:60006/api/player/{0}", model.PlayerId), model);
        }
    }
}
