using DirectiveHub.WebApi.Adaptor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DirectiveHub.WebApi.Controllers
{
    public class ServiceController : ApiController
    {
        #region Merchant
        [Route("Service/Ping")]
        public HttpResponseMessage Ping()
        {
            // Pong message
            return Request.CreateResponse(HttpStatusCode.OK, new DirectiveServiceResponse()
            {
                MessageType = DirectiveServiceResponse.ServiceMessageType.Success,
                Message = "Pong",
                Payload = new object()
            });
        }

        [Route("Service/CreateDirective")]
        public HttpResponseMessage CreateDirective(DirectiveClientModel model)
        {
            return null;
        }

        [Route("Service/ReconcileDirective")]
        public HttpResponseMessage ReconcileDirective(DirectiveClientModel model)
        {
            return null;
        }

        [Route("Service/DeleteDirective")]
        public HttpResponseMessage DeleteDirective(string ID)
        {
            return null;
        }

        [Route("Service/FindDirectives")]
        public HttpResponseMessage FindDirectives(DirectiveQuery query)
        {
            return null;
        }
        #endregion        
    }
}
