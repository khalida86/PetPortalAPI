namespace PetsPortalApp.Model
{
    public class Dog : PetBase
    {
        public Dog(Guid id, string name, int age, string owner) : base(id, name, age, owner) { }

        public override string Groom() => "Groom the Dog";
        public override string Wash() => "Wash the Dog";
        public override string Dry() => "Dry the Dog";
    }
}
