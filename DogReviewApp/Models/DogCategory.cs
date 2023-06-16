using System;
namespace DogReviewApp.Models
	//THIS REPRESENTS MANY TO MANY RELATIONSHIP, DOG AND CATEGORY
{
	public class DogCategory
	{
		public int DogId { get; set; }
		public int CategoryId { get; set; }
		public Dog Dog { get; set; }
		public Category Category { get; set; }

        public ICollection<DogCategory> DogCategories { get; set; } //Many to many
    }
}

