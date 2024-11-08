using AlzaProduct.Abstractions;
using AlzaProduct.Infrastructure.Exceptions;

namespace AlzaProduct.Application.Extensions;

public static class EntityExtensions
{
    public static void Validate<T>(this T? entity, string id) where T : Entity
    {
        if (entity is null)
        {
            throw new NotFoundException($"Entity {typeof(T).Name} with Id: {id} was not found");
        }
    }
}
