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
    public class AuthController : ApiController
    {

        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Auth(UserDTO u)
        {
            var data = AuthService.Authenticate(u.Username, u.Password);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");

            }
        }
        [HttpPost]
        [Route("api/logout")]
        public HttpResponseMessage Logout(TokenDTO tk)
        {
            var data = AuthService.Logout(tk.Key);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Logot Successfull");

            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
