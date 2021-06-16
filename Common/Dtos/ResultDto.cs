using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class ResultDto : IDto
    {
        public bool Success { get; set; }

        public ErrorDto Error { get; set; } = null;
    }
}
