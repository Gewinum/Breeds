using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class BreedDto : Dto
    {
        public string BreedName { get; set; }

        public List<BreedDto> Childs { get; set; }
    }
}
