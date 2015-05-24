using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatsWebService.DAL.Entities
{
    public class Team : EntityBase
    {
        public string Name { get; set; }

        // Use of keyword virual makes this property lazy load, which means that this property will be loaded 
        // from database only when we need to access it for read or write action
        // represent 1:many relationship
        public virtual ICollection<Player> Players { get; set; } 
    }
}