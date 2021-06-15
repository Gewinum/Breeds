using Common.Models.Attributes;
using Common.Models.Base;
using Common.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class DogBreed : BaseEntity
    {
        [Required, Unicode(DatabaseConstants.DefaultStringLength)]
        public string BreedName { get; set; }

        [Required]
        public List<DogBreed> ChildBreeds;
    }
}
