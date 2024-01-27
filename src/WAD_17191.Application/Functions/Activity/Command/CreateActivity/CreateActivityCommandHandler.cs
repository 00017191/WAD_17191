using AutoMapper;
using MediatR;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;
using WAD_17191.Domain.Models;

namespace WAD_17191.Application.Functions.Activity.Command.Create
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, ActivityDto>
    {
        private readonly IMapper _mapper;
        private readonly IActivityRepo _repo;

        public CreateActivityCommandHandler(IMapper mapper, IActivityRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<ActivityDto> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = new FitnessActivity
            {
                UserId = request.UserId,
                ActivityType = request.ActivityType,
                Duration = request.Duration,
                Distance = request.Distance,
                CaloriesBurned = request.CaloriesBurned,
				Date = DateTime.Now
		};

            await _repo.CreateAsync(activity);

            return _mapper.Map<ActivityDto>(activity);
        }
    }
}
