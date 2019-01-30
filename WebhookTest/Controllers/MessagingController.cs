using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;

namespace WebhookTest.Controllers
{
    public class MessagingController : TwilioController
    {
        [HttpPost]
        public TwiMLResult Index()
        {
            var response = new MessagingResponse();
            response.Message("Welcome!!!");
            return TwiML(response);
        }
    }
}