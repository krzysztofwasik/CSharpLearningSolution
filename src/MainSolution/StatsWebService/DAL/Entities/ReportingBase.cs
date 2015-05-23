using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatsWebService.DAL.Entities
{
    public abstract class ReportingBase
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}