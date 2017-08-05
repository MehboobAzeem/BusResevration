using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BusResevration.Models
{
    public class Resevration : ApiController
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TicketNumber { get; set; }
        public string PickPlace { get; set; }
        public string DropPlace { get; set; }
        public string CurrentStatus { get; set; }
    }
}
