namespace PetsPortalApp.Model
{
    public abstract class PetBase : IAnimal
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
        public PetBase(Guid id, string name, int age, string owner)
        {
            Id = id;
            Name = name;
            Age = age;
            Owner = owner;
        }
        public virtual string Sedate() => "Sedation Not Required";
        public virtual string Groom() => "Grooming Not Required";
        public virtual string Wash() => "Washing Not Required";
        public virtual string Dry() => "Drying Not Required";

        public List<string> GetPetCareNeeds()
        {
            List<string> results = new List<string>();
            results.Add(Sedate());
            results.Add(Groom());
            results.Add(Wash());
            results.Add(Dry());
            return results.Where(r => r.Length > 0).ToList();
        }
    }

}
