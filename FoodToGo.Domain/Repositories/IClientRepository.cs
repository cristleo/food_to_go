using System.Collections.Generic;
using FoodToGo.Domain.Entities;

namespace FoodToGo.Domain.Repositories
{
    public interface IClientRepository
    {
         Client GetClientById(int id);
         IList<Client> GetAll();
         void PersistClient(Client client);
         bool RemoveClient(Client client);
         
    }
}