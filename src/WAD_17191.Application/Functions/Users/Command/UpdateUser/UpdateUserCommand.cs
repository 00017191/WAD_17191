using MediatR;
using WAD_17191.Application.DTOs;

namespace WAD_17191.Application.Functions.Users.Command.UpdateUser
{
	public class UpdateUserCommand : IRequest<UserDto>
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public int Weight { get; set; }

		public int Age { get; set; }
	}
}
