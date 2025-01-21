using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TravelPlanner.Controllers
{
    public class TripController : ApiController
    {
        [HttpGet]
        [Route("api/Trip/GetAll")]
        public HttpResponseMessage GetAll()
        {
            var data = TripService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/Trip/Get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = TripService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/Trip/Create")]
        public HttpResponseMessage Create(TripDTO t)
        {
            TripService.Create(t);
            return Request.CreateResponse(HttpStatusCode.OK, "Trip Created Successfully!");
        }
        [HttpPut]
        [Route("api/Trip/Update")]
        public HttpResponseMessage Update(TripDTO t)
        {
            TripService.Update( t);
            return Request.CreateResponse(HttpStatusCode.OK, "Trip Updated Successfully!");
        }
        [HttpDelete]
        [Route("api/Trip/Delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            TripService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Trip Deleted Successfully!");
        }

        [HttpGet]
        [Route("api/Trip/GetTripDetails/{id}")]
        public HttpResponseMessage GetTripDetails(int id)
        {
            var data = TripService.GetTripDetails(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Trip/Calendar")]
        public HttpResponseMessage GetTripsCalendar([FromUri] DateTime startDate , [FromUri] DateTime endDate)
        {
            var data = TripService.GetTripsCalendar(startDate, endDate);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/Trip/setBudget/{id}")]
        public HttpResponseMessage SetBudget(int id,[FromBody] double budget)
        {
            TripService.SetBudget(id, budget);
            return Request.CreateResponse(HttpStatusCode.OK, "Budget Updated Successfully!");
        }
        [HttpPut]
        [Route("api/Trip/log-expense/{id}")]
        public HttpResponseMessage LogExpense(int id, [FromBody] double actualExpense)
        {
            TripService.LogExpense(id, actualExpense);
            return Request.CreateResponse(HttpStatusCode.OK, "Expense Logged Successfully!");
        }
        [HttpGet]
        [Route("api/Trip/budgetStatus/{id}")]
        public HttpResponseMessage GetBudgetStatus(int id)
        {
            var data = TripService.GetBudgetStatus(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
}
