using MediatR;
using WAD_17191.Application.DTOs;

namespace WAD_17191.Application.Functions.Activity.Query.GetActivityById
{
	public class GetActivityByIdQuery : IRequest<ActivityDto>
	{
		public int Id { get; set; }
	}
}
