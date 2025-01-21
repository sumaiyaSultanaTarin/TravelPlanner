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
    }
}
