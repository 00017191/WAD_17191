using MediatR;
using Microsoft.AspNetCore.Mvc;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Functions.User.Query.GetUserById;
using WAD_17191.Application.Functions.Users.Command.DeleteUser;
using WAD_17191.Application.Functions.Users.Command.UpdateUser;
using WAD_17191.Application.Functions.Users.Command.CreateUser;
using WAD_17191.Application.Functions.User.Query.GetAllUsers;

namespace WAD_17191.Presentation.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IMediator _mediator;

		public UserController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<List<UserDto>>> GetActivitiy()
		{
			var query = new GetAllUsersQuery();
			var books = await _mediator.Send(query);
			return Ok(books);
		}

		[HttpPost]
		public async Task<ActionResult<UserDto>> CreateUser([FromForm] CreateUserCommand command)
		{
			var result = await _mediator.Send(command);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<UserDto>> UpdateUser(int id, [FromForm] UpdateUserCommand command)
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
		public async Task<ActionResult<bool>> DeleteUser(int id)
		{
			var command = new DeleteUserCommand { Id = id };
			var result = await _mediator.Send(command);

			if (!result)
			{
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<UserDto>> GetUserById(int id)
		{
			var query = new GetUserByIdQuery { Id = id };
			var result = await _mediator.Send(query);

			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}
	}
}
