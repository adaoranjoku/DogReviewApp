using System;
//Primary key uniquely identifies
//foreign key link tables/models together
//one to one - like a unique address,   
//one to many - an indiviadual profile with many comments
//many to many - many students with many courses
namespace DogReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Owner> Owners { get; set; } //One to many, ICollection is like a list but not changeable
    }
}
