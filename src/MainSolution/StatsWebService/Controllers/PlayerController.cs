using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using StatsWebService.DAL;
using StatsWebService.DAL.Entities;
using StatsWebService.Filters;
using StatsWebService.Models;

namespace StatsWebService.Controllers
{
    public class PlayerController : BaseApiController
    {
        public PlayerController() : base(new StatsService(), new ModelFactory())
        {
        }

        public IHttpActionResult Get()
        {
            try
            {
                var players = StatsService.Players.Get();
                var models = players.Select(ModelFactory.Create);

                return Ok(models);
            }
            catch (Exception ex)
            {
                // Do some logging
                return InternalServerError(ex); // For security purpose do not send entire error message to user
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var player = StatsService.Players.Get(id);
                var model = ModelFactory.Create(player);
                return Ok(model);
            }
            catch (Exception ex)
            {
                // Do some logging
                return InternalServerError(ex); // For security purpose do not send entire error message to user
            }
        }

        [ModelValidator] // Attribute that say that this method has filter validation by class which derives from ActionFilterAttribute
        public IHttpActionResult Post([FromBody] PlayerModel playerModel)
        {
            // Validation logic is take care of by engine nad framework 
            // Cons for this solution: for each action method it has to be done
            //if(!ModelState.IsValid) return BadRequest(ModelState);

            var playerEntity = ModelFactory.Create(playerModel);
            var player = StatsService.Players.Insert(playerEntity);

            // it is bad idea to pass entity to output because of recursion problems in serialization
            // so we have to pass model based on entity
            var model = ModelFactory.Create(player);

            return Created(string.Format("http://localhost:60006/api/player/{0}", model.PlayerId), model);
        }

        [ModelValidator]
        public IHttpActionResult Put([FromBody] PlayerModel playerModel )
        {
            try
            {
                var playerEntity = ModelFactory.Create(playerModel);
                var player = StatsService.Players.Update(playerEntity);

                var model = ModelFactory.Create(player);

                return Ok(model);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                var playerEntity = StatsService.Players.Get(id);
                if (playerEntity != null)
                {
                    StatsService.Players.Delete(playerEntity);
                }
                else return NotFound();

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
