using System.Collections.Generic;

namespace FoodToGo.Domain.Entities.Validators
{
    public class ClientValidator : IValidator<Client>
    {
        IList<string> IValidator<Client>.VerifyInconsistences(Client entity)
        {
            var brokenRules = new List<string>();

            if(string.IsNullOrEmpty(entity.CPF)) 
                brokenRules.Add("CPF Obrigatório");

            if(string.IsNullOrEmpty(entity.Name))
                brokenRules.Add("Nome obrigatório");

            return brokenRules;
        }
    }
}