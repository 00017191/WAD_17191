using MediatR;
using Microsoft.AspNetCore.Mvc;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Functions.Activity.Command.Create;
using WAD_17191.Application.Functions.Activity.Command.DeleteActivity;
using WAD_17191.Application.Functions.Activity.Command.UpdateActivity;
using WAD_17191.Application.Functions.Activity.Query.GetActivityById;
using WAD_17191.Application.Functions.Activity.Query.GetAllActivities;

namespace WAD_17191.Presentation.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ActivityController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ActivityController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<List<ActivityDto>>> GetActivitiy()
		{
			var query = new GetAllActivitiesQuery();
			var books = await _mediator.Send(query);
			return Ok(books);
		}

		[HttpPost]
		public async Task<ActionResult<ActivityDto>> CreateActivity([FromForm] CreateActivityCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<ActivityDto>> UpdateActivity(int id, [FromForm] UpdateActivityCommand command)
		{
			command.Id = id;
			var result = await _mediator.Send(command);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<bool>> DeleteActivity(int id)
		{
			var command = new DeleteActivityCommand { Id = id };
			var result = await _mediator.Send(command);

			if (!result)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<ActivityDto>> GetActivityById(int id)
		{
			var query = new GetActivityByIdQuery { Id = id };
			var result = await _mediator.Send(query);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}
	}
}
