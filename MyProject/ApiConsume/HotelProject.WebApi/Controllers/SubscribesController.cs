using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribesController : ControllerBase
	{

		[HttpGet]
		public IActionResult SubscribeList()
		{
			return Ok();
		}

		[HttpPost]
		public IActionResult AddSubscribe()
		{
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteSubscribe()
		{
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateSubscribe()
		{
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetSubscribe()
		{
			return Ok();
		}
	}
}
