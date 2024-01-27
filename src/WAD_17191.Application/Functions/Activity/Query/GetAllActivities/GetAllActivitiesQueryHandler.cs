using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.Activity.Query.GetAllActivities
{
	public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, List<ActivityDto>>
	{
		private readonly IMapper _mapper;
		private readonly IActivityRepo _repo;

		public GetAllActivitiesQueryHandler(IMapper mapper, IActivityRepo repo) 
		{
			_mapper = mapper;
			_repo = repo;
		}

		public async Task<List<ActivityDto>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
		{
			var activities = await _repo.GetAll().Include(b => b.User).ToListAsync();
			return _mapper.Map<List<ActivityDto>>(activities);
		}
	}
}
