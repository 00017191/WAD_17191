namespace WAD_17191.Domain.Models
{
	public class User
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public int Weight { get; set; }

		public int Age { get; set; }

		public ICollection<FitnessActivity> Activities { get; set; }
	}
}
