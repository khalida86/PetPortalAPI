namespace PetsPortalApp
{
    public interface IPetManager
    {
        //List<IAnimal> Pets { get; set; }
        List<IAnimal> GetAll();
        IAnimal GetByName(string name);
        List<string> GetCareSteps(string name);
    }
}
