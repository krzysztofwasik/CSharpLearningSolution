using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatsWebService.Models
{
    public class GameEventModel
    {
        [Required]
        public int GameId { get; set; }

        [Required]
        public int PlayerId { get; set; }

        [Required]
        public int PointValue { get; set; }
    }
}