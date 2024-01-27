using AutoMapper;
using MediatR;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.User.Query.GetUserById
{
	public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
	{
		private readonly IMapper _mapper;
		private readonly IUserRepo _repo;

		public GetUserByIdQueryHandler(IMapper mapper, IUserRepo repo)
		{
			_mapper = mapper;
			_repo = repo;
		}

		public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
		{
			var user = await _repo.GetByIdAsync(request.Id);
			return _mapper.Map<UserDto>(user);
		}
	}
}
