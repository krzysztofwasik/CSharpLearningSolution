using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.ModelBinding;
using StatsWebService.DAL;
using StatsWebService.Models;
using StatsWebService.Filters;

namespace StatsWebService.Controllers
{
    public class GameController : BaseApiController
    {
        public GameController() : base(new StatsService(), new ModelFactory())
        {
        }

        public IHttpActionResult Get()
        {
            try
            {
                var gameEntities = StatsService.Games.Get();
                var models = gameEntities.Select(ModelFactory.Create);

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
                var gameEntities = StatsService.Games.Get(id);
                var model = ModelFactory.Create(gameEntities);

                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [ModelValidator]
        public IHttpActionResult CreateEvent([FromBody] GameEventModel gameEventModel)
        {
            try
            {
                var gameEntity = StatsService.Games.Get(gameEventModel.GameId);
                var playerEntity = StatsService.Players.Get(gameEventModel.PlayerId);
                var pointValue = gameEventModel.PointValue;

                var gameEventEntity = ModelFactory.Create(gameEntity, playerEntity, pointValue);
                StatsService.Events.Insert(gameEventEntity);

                return Created(string.Format("http://localhost:60006/api/game/{0}", gameEventModel.GameId), gameEventModel);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
