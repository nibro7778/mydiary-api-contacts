using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyDiary.Contacts.Web.Feature.PingMe
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PingMeController : ControllerBase
    {
        [HttpGet]
        [Route("Reply")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> Reply()
        {
            return Ok("I am available");
        }
    }
}
