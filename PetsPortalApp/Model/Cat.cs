namespace PetsPortalApp.Model
{
    public class Cat : PetBase
    {
        public Cat(int id, string name, int age, string owner, string type) : base(id, name, age, owner, type) { }

        public override string Sedate() => "Sedate the Cat";
        public override string Groom() => "Groom the Cat";
        public override string Wash() => "Wash the Cat";
        public override string Dry() => "Dry the Cat";
    }
}
