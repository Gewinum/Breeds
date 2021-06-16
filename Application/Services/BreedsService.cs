using Application.Providers.Interfaces;
using Application.Services.Interfaces;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http.Json;
using Common.Dtos;

namespace Application.Services
{
    public class BreedsService : IBreedsService
    {
        private HttpClient httpClient = new HttpClient();

        private readonly IDatabaseProvider databaseProvider;

        public BreedsService(IDatabaseProvider _databaseProvider)
        {
            databaseProvider = _databaseProvider;
        }

        public ResultDto InitBreeds()
        {
            if (databaseProvider.Count<DogBreed>() != 0)
            {
                return GetResultErrorDto("Call DELETE /breeds for clearing all breeds.");
            }

            LoadBreedsByRequest();

            return GetResultSuccessDto();
        }

        private void LoadBreedsByRequest()
        {
            Task<IncomingBreedDto> httpRequestTask = httpClient.GetFromJsonAsync<IncomingBreedDto>("https://dog.ceo/api/breeds/list/all");

            httpRequestTask.Wait();

            IncomingBreedDto breedsList = httpRequestTask.Result;

            foreach(KeyValuePair<string, List<string>> entry in breedsList.Message)
            {
                string breedName = entry.Key;
                string childs = String.Join(";", entry.Value);

                databaseProvider.Create(GetDogBreedModel(breedName, childs));
            }

            databaseProvider.Commit();
        }
        
        private DogBreed GetDogBreedModel(string breedName, string childBreeds)
        {
            return new DogBreed
            {
                BreedName = breedName,
                ChildBreeds = childBreeds
            };
        }

        private ResultDto GetResultSuccessDto()
        {
            return new ResultDto
            {
                Success = true
            };
        }

        private ResultDto GetResultErrorDto(string errorMessage)
        {
            return new ResultDto
            { 
                Success = false,
                Error = new ErrorDto { Message = errorMessage }
            };
        }
    }
}
