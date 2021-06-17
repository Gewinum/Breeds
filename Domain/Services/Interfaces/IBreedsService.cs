using Common.Dtos;
using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IBreedsService
    {
        ResultDto InitBreeds();

        BreedsListDto GetAllBreeds();

        ResultDto RemoveAllBreeds();

        IDto GetBreedByName(string breedName);

        IDto GetBreedImages(string breedName, int imagesLimit);
    }
}
