using PetsPortalApp.Model;
using PetsPortalApp.Context;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;

namespace PetsPortalApp
{
    public class PetManager : IPetManager
    {
        private List<IAnimal> Pets { get; set; }
        private readonly PetContext _petContext;
        public PetManager(PetContext context)
        {
            Pets = new List<IAnimal>();
            Pets.Add(new Dog(0, "Duke", 3, "Superman", "Dog"));
            Pets.Add(new Dog(1, "Paco", 3, "Spiderman", "Dog"));
            Pets.Add(new Cat(2, "Simba", 3, "Batman","Cat"));
            Pets.Add(new Bird(3, "Diego", 3, "Jaffar","Bird"));
            
            _petContext = context;
        }

        //public List<IAnimal> GetAll()
        //{
        //    List<IAnimal> clonedPets = new List<IAnimal>(Pets);
        //    return clonedPets;
        //}

        public async Task<IEnumerable<IAnimal>> GetAll()
        {
            var query = "SELECT * FROM Pet";

            using (var connection = _petContext.CreateConnection())
            {
                var pets = await connection.QueryAsync<PetBase>(query);
                return pets.ToList();
            }
        }

        public async Task<IAnimal> GetById(int id)
        {
            var query = "SELECT * FROM Pet WHERE Id = @Id";

            using (var connection = _petContext.CreateConnection())
            {
                var pet = await connection.QuerySingleOrDefaultAsync<PetBase>(query, new { id });
                //return pet;
                return pet == null ? null : PetFactory.CreatePet(pet.Id, pet.Name, pet.Type, pet.Age, pet.Owner);
                //return fullPetRecord;
            }
        }

        //public IAnimal GetById(string id)
        //{
        //    List<IAnimal> clonedPets = new List<IAnimal>(Pets);
        //    return clonedPets.Where(p => p.Id.ToString().Equals(id)).Single();
        //}

        public IEnumerable<string>? GetCareSteps(int id)
        {
            /* var query = "SELECT Type FROM Pet Where Id = @Id";
             var parameters = new DynamicParameters();
             parameters.Add("Id", id, DbType.Int32, ParameterDirection.Input);

             using (var connection = _petContext.CreateConnection())
             {
                 //string pettype;
                 var pettype = connection.Query<string>(query, parameters).ToList(); 
                 *//* connection.QuerySingleOrDefaultAsync<PetBase>(query, parameters);*//*
                 //System.Diagnostics.Debug.WriteLine(pettype);
                 return pettype;
             }*/

            //IAnimal mockimal = GetById(id).Result;
            //IAnimal? actualimal = mockimal == null ? null : PetFactory.CreatePet(mockimal.Id, mockimal.Name,  mockimal.Type, mockimal.Age, mockimal.Owner);
            //return actualimal?.GetPetCareNeeds();
            var pet = GetById(id).Result;
            return pet?.GetPetCareNeeds();
        }

        //public List<string> GetCareSteps(int id)
        //{
        //    var pet = GetById(id);
        //    if (pet != null)
        //    {
        //        return pet.GetPetCareNeeds();
        //    }
        //    return new List<string>() { "No care needs found." };
        //}
    }
    public class PetFactory
    {
        public static IAnimal? CreatePet(int id, string name, string type, int age, string owner)
        {
            switch(type.ToLower())
            {
                case "dog":
                    return new Dog(id, name, age, owner, type);
                case "cat":
                    return new Cat(id, name, age, owner, type);
                case "bird":
                    return new Bird(id, name, age, owner, type);
                default:
                    return null;
            }
        }
    }

}

