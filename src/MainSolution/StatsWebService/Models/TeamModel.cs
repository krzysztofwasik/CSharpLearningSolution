using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Http;
using StatsWebService.DAL;
using StatsWebService.DAL.Entities;
using StatsWebService.Filters;

namespace StatsWebService.Models
{
    public class TeamModel 
    {
        public int TeamId { get; set; }
        
        [Required]
        public string TeamName { get; set; }

        public List<PlayerModel> Players { get; set; } 
    }
}