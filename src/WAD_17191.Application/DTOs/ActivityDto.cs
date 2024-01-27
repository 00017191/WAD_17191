using WAD_17191.Domain.Models;

namespace WAD_17191.Application.DTOs
{
	public class ActivityDto
	{
		public int Id { get; set; }

		public int UserId { get; set; }

		public string ActivityType { get; set; }

		public int Duration { get; set; }

		public int Distance { get; set; }

		public int CaloriesBurned { get; set; }

		public DateTime Date { get; set; }
	}
}
