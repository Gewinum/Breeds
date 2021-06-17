﻿using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class BreedDto : IDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ChildBreedDto> Childs { get; set; }
    }
}
