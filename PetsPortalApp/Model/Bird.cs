namespace PetsPortalApp.Model
{
    public class Bird : PetBase
    {
        public Bird(Guid id, string name, int age, string owner) : base(id, name, age, owner) { }
        public override string Wash() => "Wash the Bird";
        public override string Dry() => "Dry the Bird";
    }
}
