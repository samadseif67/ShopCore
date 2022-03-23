using Microsoft.AspNetCore.Mvc;

namespace Shop.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

         

        [HttpGet]
        [Route("GetLstName")]
        public List<string> GetLstName()
        {
            List<string> lst = new List<string>();
            lst.Add("ali");
            lst.Add("samad");
            lst.Add("younes");

            return lst;
        }




    }
}