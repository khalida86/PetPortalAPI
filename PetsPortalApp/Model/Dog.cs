namespace PetsPortalApp.Model
{
    public class Dog : PetBase
    {
        public Dog(int id, string name, int age, string owner, string type) : base(id, name, age, owner, type) { }

        public override string Groom() => "Groom the Dog";
        public override string Wash() => "Wash the Dog";
        public override string Dry() => "Dry the Dog";
    }
}
