using System;
using System.Collections.Generic;
using FoodToGo.Domain.Entities.Validators;

namespace FoodToGo.Domain.Entities
{
    public class Client : IValidatable<Client>
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string CPF {get;set;}
        public DateTime BirthDate {get;set;}

        bool IValidatable<Client>.Validate(IValidator<Client> validador, out IList<string> brokenRules)
        {
            brokenRules = validador.VerifyInconsistences(this);
            return (brokenRules.Count > 0);
        }
    }
}