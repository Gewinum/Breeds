using Application.Services;
using Application.Services.Interfaces;
using Common.Dtos;
using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Controllers
{
    public class BreedsController : Controller
    {
        private readonly IBreedsService breedsService;

        public BreedsController(IBreedsService _breedsService)
        {
            breedsService = _breedsService;
        }

        [HttpGet("breeds")]
        public BreedsListDto GetAll()
        {
            return "all";
        }

        [HttpDelete("breeds")]
        public string RemoveAll()
        {
            return "removed";
        }

        [HttpPost("init")]
        public void InitBreeds()
        {
            breedsService.InitBreeds();
        }
    }
}
