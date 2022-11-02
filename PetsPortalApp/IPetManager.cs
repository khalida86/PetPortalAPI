using Microsoft.OpenApi.Any;

namespace PetsPortalApp
{
    public interface IPetManager
    {
        //List<IAnimal> Pets { get; set; }
        //List<IAnimal> GetAll();
        public Task<IEnumerable<IAnimal>> GetAll();
        //IAnimal GetById(string id);
        public Task<IAnimal> GetById(int id);
        public IEnumerable<string> GetCareSteps(int id);
        //public List<string> GetCareSteps(int id);
    }
}
