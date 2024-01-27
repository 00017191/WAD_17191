using MediatR;
using WAD_17191.Application.DTOs;

namespace WAD_17191.Application.Functions.User.Query.GetAllUsers
{
	public class GetAllUsersQuery : IRequest<List<UserDto>>
	{
	}
}
