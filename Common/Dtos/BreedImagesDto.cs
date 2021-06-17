using Common.Dtos.Interfaces;
using Common.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class BreedImagesDto<T> : IDto
    {
        public T Breed;

        public List<string> Images;
    }
}
