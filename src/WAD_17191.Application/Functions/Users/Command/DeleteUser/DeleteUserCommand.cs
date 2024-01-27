using MediatR;

namespace WAD_17191.Application.Functions.Users.Command.DeleteUser
{
	public class DeleteUserCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
