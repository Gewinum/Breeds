using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using Common.Dtos;
using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Common.Dtos.Interfaces;

namespace BusinessLogic.Controllers
{
    public class BreedsController : Controller
    {
        private readonly IBreedsService breedsService;

        public BreedsController(IBreedsService _breedsService)
        {
            breedsService = _breedsService;
        }

        [HttpGet("breeds")]
        public BreedsListDto GetAllBreeds()
        {
            return breedsService.GetAllBreeds();
        }

        [HttpDelete("breeds")]
        public ResultDto RemoveAllBreeds()
        {
            return breedsService.RemoveAllBreeds();
        }

        [HttpPost("init")]
        public ResultDto InitBreeds()
        {
            return breedsService.InitBreeds();
        }

        [HttpGet("/breeds/{breedName}")]
        public IDto GetBreedByName(string breedName)
        {
            return breedsService.GetBreedByName(breedName);
        }

        [HttpGet("/breeds/{breedName}/images")]
        public IDto GetBreedImages(string breedName, [FromQuery] int limit)
        {
            return breedsService.GetBreedImages(breedName, limit);
        }
    }
}
