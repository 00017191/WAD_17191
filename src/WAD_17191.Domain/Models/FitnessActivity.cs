namespace WAD_17191.Domain.Models
{
	public class FitnessActivity
	{
		public int Id { get; set; }

		public int UserId { get; set; }

		public User User { get; set; }

		public string ActivityType { get; set; }

		public int Duration { get; set; }

		public int Distance { get; set; }

		public int CaloriesBurned { get; set; }

		public DateTime Date { get; set; }
	}
}
