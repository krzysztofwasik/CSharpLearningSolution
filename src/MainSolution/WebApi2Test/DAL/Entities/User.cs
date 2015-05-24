using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2Test.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }

        public DateTime DateCreated { get; set; }
    }
}