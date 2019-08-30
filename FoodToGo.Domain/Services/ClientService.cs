using System.Collections.Generic;
using FoodToGo.Domain.Entities.Validators;
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

        public bool PersistClient(Client client)
        {
            IList<string> brokenRules;
            IValidator<Client> validator = new ClientValidator();
          
            if(!((IValidatable<Client>)client).Validate(validator, out brokenRules))
                return false;
            else
                return true;

        }



        
    }


}