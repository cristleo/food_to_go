using System.Collections.Generic;
using FoodToGo.Domain.Entities.Validators;

namespace FoodToGo.Domain.Entities
{
    public interface IValidatable<T>
    {
        bool Validate(IValidator<T> validador, out IList<string> brokenRules);   
    }
    
}