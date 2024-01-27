using MediatR;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.Users.Command.DeleteUser
{
	public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
	{
		private readonly IUserRepo _repo;

		public DeleteUserCommandHandler(IUserRepo repo)
		{
			_repo = repo;
		}

		public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
		{
			var user = await _repo.GetByIdAsync(request.Id);

			if (user == null)
			{
				return false;
			}

			await _repo.DeleteAsync(request.Id);

			return true;
		}
	}
}
