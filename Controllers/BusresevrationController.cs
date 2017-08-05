using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusResevration.Models;

namespace BusResevration.Controllers
{
    public class BusresevrationController : ApiController
    {
        public bool NewUser(Resevration U)
        {

            return true;
        }

        public bool Resevration(Resevration R)
        {

            return true;
        }
       
        public string CheckReservtionsStatus(int ticketNumber)
        {
            Resevration r = new Resevration();
            return r.CurrentStatus;
        }
        public bool CancelResevrtion(int ResevrtionId)
        {

            return true;
        }

        public List<string>getResevrtions()
        {
            List<string> resevrtions = new List<string>();
            return resevrtions;
        } 


    }
}
