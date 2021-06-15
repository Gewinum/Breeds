using Application.Providers.Interfaces;
using Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BreedsService : IBreedsService
    {
        private readonly IDatabaseProvider databaseProvider;

        public BreedsService(IDatabaseProvider _databaseProvider)
        {
            databaseProvider = _databaseProvider;
        }

        public void InitBreeds()
        {
            
        }

        private void MakeHttpRequest()
        {

        }
    }
}
