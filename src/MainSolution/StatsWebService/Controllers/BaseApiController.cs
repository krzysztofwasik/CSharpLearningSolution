using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StatsWebService.DAL;
using StatsWebService.Models;

namespace StatsWebService.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        private readonly IStatsService service;
        private readonly IModelFactory modelFactory;

        protected BaseApiController(IStatsService statsService, IModelFactory modelFatory)
        {
            this.service = statsService;
            this.modelFactory = modelFatory;
        }

        protected IModelFactory ModelFactory
        {
            get { return this.modelFactory; }
        }

        protected IStatsService StatsService
        {
            get { return this.service; }
        }
    }
}
