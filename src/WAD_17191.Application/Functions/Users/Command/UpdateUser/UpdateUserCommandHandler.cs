using AutoMapper;
using MediatR;
using WAD_17191.Application.DTOs;
using WAD_17191.Application.Interfaces;

namespace WAD_17191.Application.Functions.Users.Command.UpdateUser
{
	public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserDto>
	{
		private readonly IMapper _mapper;
		private readonly IUserRepo _repo;

		public UpdateUserCommandHandler(IMapper mapper, IUserRepo repo)
		{
			_mapper = mapper;
			_repo = repo;
		}

		public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
		{
			var user = await _repo.GetByIdAsync(request.Id);

			if (user == null)
			{
				return null;
			}

			user.Name = request.Name;
			user.Email = request.Email;
			user.Age = request.Age;
			user.Weight = request.Weight;

			await _repo.UpdateAsync(user);

			return _mapper.Map<UserDto>(user);
		}
	}
}
