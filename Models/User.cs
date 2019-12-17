using System.Collections.Generic;

namespace DogShelter.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<Adoption> Adoptions { get; set; }
        public ICollection<CatAdoption> CatAdoptions { get; set; }
    }
}