using MediatR;

namespace WAD_17191.Application.Functions.Activity.Command.DeleteActivity
{
	public class DeleteActivityCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
