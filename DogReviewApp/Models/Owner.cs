using System;
namespace DogReviewApp.Models
{
	public class Owner
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Country Country { get; set; } // Only has one country associated with it
        public ICollection<DogOwner> DogOwners { get; set; } //Many to many


    }
}

