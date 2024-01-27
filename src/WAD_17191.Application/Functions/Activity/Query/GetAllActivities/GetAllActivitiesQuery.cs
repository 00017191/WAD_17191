using MediatR;
using WAD_17191.Application.DTOs;

namespace WAD_17191.Application.Functions.Activity.Query.GetAllActivities
{
	public class GetAllActivitiesQuery : IRequest<List<ActivityDto>>
	{
	}
}
