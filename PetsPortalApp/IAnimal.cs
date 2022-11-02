namespace PetsPortalApp
{
    public interface IAnimal : IAccessor
    {
        int Id { get; }
        string Name { get; set; }
        int Age { get; set; }
        string Owner { get; set; }
        string Type { get; set; }
    }
}
