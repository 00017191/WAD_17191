using AutoMapper;
using MediatR;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.User.Query.GetAllUsers
{
	public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
	{
		private readonly IMapper _mapper;
		private readonly IUserRepo _repo;

		public GetAllUsersQueryHandler(IMapper mapper, IUserRepo repo)
		{
			_mapper = mapper;
			_repo = repo;
		}

		public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
		{
			var users = await _repo.GetAllAsync();
			return  _mapper.Map<List<UserDto>>(users);
		}
	}
}
