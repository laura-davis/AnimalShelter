using System;

namespace DogShelter.Models
{
    public class CatAdoption
    {
        public int CatAdoptionID { get; set; }
        public int CatID { get; set; }
        public int UserID { get; set; }
        public DateTime AdoptionDate { get; set; }
        public Cat Cat { get; set; }
        public User User { get; set; }
    }
}