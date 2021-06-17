using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class IncomingBreedImagesDto : IDto
    {
        public List<string> Message { get; set; }

        public bool Success { get; set; }
    }
}
