using Microsoft.OpenApi.Any;

namespace PetsPortalApp
{
    public interface IPetManager
    {
        //List<IAnimal> Pets { get; set; }
        List<IAnimal> GetAll();
        IAnimal GetById(string id);
        List<string> GetCareSteps(string id);
    }
}
