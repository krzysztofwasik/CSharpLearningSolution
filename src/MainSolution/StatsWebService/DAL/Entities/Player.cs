using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatsWebService.DAL.Entities
{
    public class Player : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // represent 1:1 relationship
        public virtual  Team Team { get; set; }
    }
}