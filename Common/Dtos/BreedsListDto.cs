using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class BreedsListDto : IDto
    {
        public List<BreedDto> Breeds { get; set; }

        public bool Success { get; } = true;
    }
}
