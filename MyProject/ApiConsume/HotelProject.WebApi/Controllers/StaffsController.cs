﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffsController : ControllerBase
	{
		[HttpGet]
		public IActionResult StaffList()
		{
			return Ok();
		}

		[HttpPost]
		public IActionResult AddStaff()
		{
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteStaff()
		{
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateStaff()
		{
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetStaff()
		{
			return Ok();
		}
	}
}
