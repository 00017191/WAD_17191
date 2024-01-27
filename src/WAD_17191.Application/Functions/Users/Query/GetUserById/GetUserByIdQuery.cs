using MediatR;
using WAD_17191.Application.DTOs;

namespace WAD_17191.Application.Functions.User.Query.GetUserById
{
	public class GetUserByIdQuery : IRequest<UserDto>
	{
		public int Id { get; set; }
	}
}
