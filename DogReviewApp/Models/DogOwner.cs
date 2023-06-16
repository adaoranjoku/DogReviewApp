using System;
namespace DogReviewApp.Models
//THIS REPRESENTS MANY TO MANY RELATIONSHIP, DOG AND Owner
{
    public class DogOwner
    {
        public int DogId { get; set; }
        public int OwnerId { get; set; }
        public Dog Dog { get; set; }
        public Owner Owner { get; set; }
    }
}


