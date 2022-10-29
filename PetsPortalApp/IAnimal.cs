namespace PetsPortalApp
{
    public interface IAnimal : IAccessor
    {
        Guid Id { get; }
        string Name { get; set; }
        int Age { get; set; }
        string Owner { get; set; }
    }
}
