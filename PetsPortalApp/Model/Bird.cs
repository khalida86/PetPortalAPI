namespace PetsPortalApp.Model
{
    public class Bird : PetBase
    {
        public Bird(int id, string name, int age, string owner, string type) : base(id, name, age, owner, type) { }
        public override string Wash() => "Wash the Bird";
        public override string Dry() => "Dry the Bird";
    }
}
