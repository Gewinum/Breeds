﻿using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class ErrorDto : IDto
    {
        public string Message { get; set; }
    }
}
