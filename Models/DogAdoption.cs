using System;

namespace AnimalShelter.Models
{
    public class Adoption
    {
        public int AdoptionID { get; set; }
        public int DogID { get; set; }
        public int UserID { get; set; }
        public Dog Dog { get; set; }
        public User User { get; set; }
        public DateTime AdoptionDate { get; set; }
    }
}