namespace PetsPortalApp.Model
{
    public class Cat : PetBase
    {
        public Cat(Guid id, string name, int age, string owner) : base(id, name, age, owner) { }

        public override string Sedate() => "Sedate the Cat";
        public override string Groom() => "Groom the Cat";
        public override string Wash() => "Wash the Cat";
        public override string Dry() => "Dry the Cat";
    }
}
