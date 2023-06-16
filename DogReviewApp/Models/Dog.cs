using System;
namespace DogReviewApp.Models
//Model - CLASS W BUNCH OF PROPERTIES,  DATABASE TABLES(KIND OF LINK EXCEL SPREADSHEET)
{
	public class Dog
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Breed { get; set; }
		public int Age { get; set; }


		public ICollection<Review> Reviews { get; set; } //One to many, ICollection is like a list but not changeable

        public ICollection<DogCategory> DogCategories { get; set; } //Many to many
        public ICollection<DogOwner> DogOwners { get; set; } //Many to many

    }

}
