using AutoMapper;
using MediatR;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.Activity.Command.UpdateActivity
{
	public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand, ActivityDto>
	{
		private readonly IMapper _mapper;
		private readonly IActivityRepo _repo;

		public UpdateActivityCommandHandler(IMapper mapper, IActivityRepo repo)
		{
			_mapper = mapper;
			_repo = repo;
		}
		public async Task<ActivityDto> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
		{
			var activity = await _repo.GetByIdAsync(request.Id);

			if (activity == null)
			{
				return null;
			}

			activity.UserId = request.UserId;
			activity.ActivityType = request.ActivityType;
			activity.Duration = request.Duration;
			activity.Distance = request.Distance;
			activity.CaloriesBurned = request.CaloriesBurned;
			activity.Date = DateTime.Now;

			_repo.UpdateAsync(activity);

			return _mapper.Map<ActivityDto>(activity);
		}
	}
}
