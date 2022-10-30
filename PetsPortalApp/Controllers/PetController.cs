using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;

namespace PetsPortalApp.Controllers
{

    [ApiController]
    //[Route("[controller]")]
    [Route("api/")]
    public class PetController : ControllerBase
    {
        private readonly ILogger<PetController> _logger;
        private readonly IPetManager _petManager;
        public PetController(ILogger<PetController> logger, IPetManager petManager)
        {
            _logger = logger;
            _petManager = petManager;
        }

        [HttpGet("GetAll")]
        public List<IAnimal> GetAll()
        {
            return _petManager.GetAll();

        }

        [HttpGet("GetById")]
        public IAnimal GetById(string id)
        {
            return _petManager.GetById(id);

        }

        [HttpGet("GetCareSteps")]
        public List<string> GetCareSteps(string id)
        {
            return _petManager.GetCareSteps(id);

        }
    }
}