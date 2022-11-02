using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using System.Data;
using System.Data.SqlClient;
using PetsPortalApp.Model;

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
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var pets = await _petManager.GetAll();
                return Ok(pets);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //[HttpGet("{id}" , Name = "GetById")]
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var pet = await _petManager.GetById(id);
            if (pet == null)
            {
                return StatusCode(204, "Pet does not exist");
            }
            else
            {
                return Ok(pet);
            }
            //try
            //{
            //    var pet = await _petManager.GetById(id);
            //    return Ok(pet);
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(500, "Pet does not exist");
            //}
        }

        [HttpGet("GetCareSteps")]
        public async Task<IActionResult> GetCareSteps(int id)
        {
   
            IEnumerable<string> careSteps = _petManager.GetCareSteps(id);

            if(careSteps == null)
            {
                return StatusCode(204, "Pet or Pet type does not exist");
            }
            else
            {
                return Ok(careSteps);
            }
            
        }
    }
}