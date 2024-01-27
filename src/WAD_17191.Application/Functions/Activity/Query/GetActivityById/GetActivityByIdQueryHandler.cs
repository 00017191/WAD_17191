using AutoMapper;
using MediatR;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.Activity.Query.GetActivityById
{
	public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, ActivityDto>
	{
		private readonly IMapper _mapper;
		private readonly IActivityRepo _repo;
		public GetActivityByIdQueryHandler(IMapper mapper, IActivityRepo repo) 
		{
			_mapper = mapper;
			_repo = repo;
		}
		public async Task<ActivityDto> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
		{
			var activity = await _repo.GetByIdAsync(request.Id);
			return _mapper.Map<ActivityDto>(activity);
		}
	}
}
