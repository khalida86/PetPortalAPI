using PetsPortalApp.Contracts;
using PetsPortalApp.Context;
using PetsPortalApp.Model;
using Dapper;

namespace PetsPortalApp.Repository
{
    //public class PetsRepository : IPetsRepository
    //{
    //    private readonly PetContext _context;

    //    public PetsRepository(PetContext context)
    //    {
    //        _context = context;
    //    }

    //    public async Task<IEnumerable<PetBase>> GetAllV2()
    //    {
    //        var query = "SELECT * FROM Pet";

    //        using (var connection = _context.CreateConnection())
    //        {
    //            var pets = await connection.QueryAsync<PetBase>(query);
    //            return pets.ToList();
    //        }
    //    }
    //}
}
