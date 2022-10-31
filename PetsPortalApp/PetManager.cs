using Microsoft.OpenApi.Any;
using PetsPortalApp.Model;

namespace PetsPortalApp
{
    public class PetManager : IPetManager
    {
        private List<IAnimal> Pets { get; set; }
        public PetManager()
        {
            Pets = new List<IAnimal>();
            Pets.Add(new Dog(Guid.NewGuid(), "Duke", 3, "Superman"));
            Pets.Add(new Dog(Guid.NewGuid(), "Paco", 3, "Spiderman"));
            Pets.Add(new Cat(Guid.NewGuid(), "Simba", 3, "Batman"));
            Pets.Add(new Bird(Guid.NewGuid(), "Diego", 3, "Jaffar"));
        }

        public List<IAnimal> GetAll()
        {
            List<IAnimal> clonedPets = new List<IAnimal>(Pets);
            return clonedPets;
        }

        public IAnimal GetById(string id)
        {
            List<IAnimal> clonedPets = new List<IAnimal>(Pets);
            // return clonedPets.Where(p => string.Equals(p.Name, name)).First(); // return null if not found
            return clonedPets.Where(p => p.Id.ToString().Equals(id)).First(); // return null if not found
        }

        public List<string> GetCareSteps(string id)
        {
            List<IAnimal> clonedPets = new List<IAnimal>(Pets);
            var pet = clonedPets.Where(p => p.Id.ToString().Equals(id)).First();
            if (pet != null)
            {
                return pet.GetPetCareNeeds();
            }
            return new List<string>() { "No care needs found." };
        }
    }
}
