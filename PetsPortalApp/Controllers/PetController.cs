using Microsoft.AspNetCore.Mvc;

namespace PetsPortalApp.Controllers
{

    [ApiController]
    //[Route("[controller]")]
    [Route("api/")]
    public class PetController : ControllerBase
    {
        //PetManager manager = new PetManager();
        private readonly ILogger<PetController> _logger;
        private readonly IPetManager _petManager;
        public PetController(ILogger<PetController> logger, IPetManager petManager)
        {
            _logger = logger;
            _petManager = petManager;
        }

        [HttpGet("GetByName")]
        public IAnimal GetByName(string name)
        {
            return _petManager.GetByName(name);

        }

        [HttpGet("GetAll")]
        public List<IAnimal> GetAll()
        {
            return _petManager.GetAll();

        }

        [HttpGet("GetCareSteps")]
        public List<string> GetCareSteps(string name)
        {
            return _petManager.GetCareSteps(name);

        }
    }
}