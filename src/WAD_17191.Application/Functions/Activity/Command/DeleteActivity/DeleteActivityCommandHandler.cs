using AutoMapper;
using MediatR;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.Activity.Command.DeleteActivity
{
	public class DeleteActivityCommandHandler : IRequestHandler<DeleteActivityCommand, bool>
	{
		private readonly IActivityRepo _repo;

		public DeleteActivityCommandHandler(IActivityRepo repo)
		{
			_repo = repo;
		}

		public async Task<bool> Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
		{
			var activity = await _repo.GetByIdAsync(request.Id);

			if (activity == null)
			{
				return false;
			}

			await _repo.DeleteAsync(request.Id);

			return true;
		}
	}
}
