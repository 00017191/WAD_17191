using AutoMapper;
using MediatR;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.Users.Command.CreateUser
{
	public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
	{
		private readonly IMapper _mapper;
		private readonly IUserRepo _repo;

		public CreateUserCommandHandler(IMapper mapper, IUserRepo repo)
		{
			_mapper = mapper;
			_repo = repo;
		}

		public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
			// Cant see user model in domain layer
			var user = new WAD_17191.Domain.Models.User
			{
				Name = request.Name,
				Email = request.Email,
				Age = request.Age,
				Weight = request.Weight,
			};

			await _repo.CreateAsync(user);

			return _mapper.Map<UserDto>(user);
		}
	}
}
