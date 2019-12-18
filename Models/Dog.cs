using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DogShelter.Models
{
    public class Dog
    {
        public int ID { get; set; }
        
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }
        
        [Required]
        [Display(Name = "Breed")]
        public string Breed { get; set; }
        
        [Required]
        [Display(Name = "Sex")]
        public string Sex { get; set; }
        
        [Display(Name = "Summary")]
        public string Summary { get; set; }
        
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public ICollection<Adoption> Adoptions { get; set; }
    }
}