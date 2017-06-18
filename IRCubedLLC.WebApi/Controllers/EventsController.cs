using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Hosting;
using System.Text;

namespace IRCubedLLC.WebApi.Controllers
{
    public class EventsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var json = File.ReadAllText(HostingEnvironment.MapPath(@"~/App_Data/events.json"));

            return new HttpResponseMessage()
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.Accepted
            };
        }
    }
}
