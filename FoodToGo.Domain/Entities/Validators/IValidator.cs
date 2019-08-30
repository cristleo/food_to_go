using System.Collections.Generic;

namespace FoodToGo.Domain.Entities.Validators
{
    public interface IValidator<T>
    {
        IList<string> VerifyInconsistences (T entity);
    }
}