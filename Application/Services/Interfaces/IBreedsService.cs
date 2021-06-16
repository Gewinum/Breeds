using Common.Dtos;
using Common.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IBreedsService
    {
        ResultDto InitBreeds();

        BreedsListDto GetAllBreeds();

        ResultDto RemoveAllBreeds();

        IDto GetBreedById(int id);

        BreedWithImagesDto GetBreedWithImages(int id, int imagesLimit);
    }
}
