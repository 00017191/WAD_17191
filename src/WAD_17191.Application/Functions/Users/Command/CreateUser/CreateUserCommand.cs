using MediatR;
using WAD_17191.Application.DTOs;

namespace WAD_17191.Application.Functions.Users.Command.CreateUser
{
	public class CreateUserCommand : IRequest<UserDto>
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public int Weight { get; set; }

		public int Age { get; set; }
	}
}
