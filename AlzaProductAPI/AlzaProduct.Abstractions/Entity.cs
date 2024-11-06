namespace AlzaProduct.Abstractions;

public class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; }
}
