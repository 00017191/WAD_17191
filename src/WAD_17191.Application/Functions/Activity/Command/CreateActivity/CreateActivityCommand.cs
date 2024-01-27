using MediatR;
using WAD_17191.Application.DTOs;

namespace WAD_17191.Application.Functions.Activity.Command.Create
{
    public class CreateActivityCommand : IRequest<ActivityDto>
    {
        public int UserId { get; set; }

        public string ActivityType { get; set; }

        public int Duration { get; set; }

        public int Distance { get; set; }

        public int CaloriesBurned { get; set; }
    }
}
