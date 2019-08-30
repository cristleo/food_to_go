using FoodToGo.Domain.Repositories;

namespace FoodToGo.Domain.Entities.Services
{
    
    public class ClientService
    {
        private IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }



        
    }


}