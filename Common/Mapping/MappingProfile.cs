using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Common.Dtos;
using Common.Models;

namespace Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DogBreed, BreedDto>().ReverseMap();

            CreateMap<ChildDogBreed, ChildBreedDto>().ReverseMap();
        }
    }
}
