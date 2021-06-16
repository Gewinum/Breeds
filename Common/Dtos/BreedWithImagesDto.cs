using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class BreedWithImagesDto : IDto
    {
        public BreedDto Breed;

        public List<string> Images;
    }
}
