using CloudConfVarnaEdition4._0.Entities;
using CloudConfVarnaEdition4._0.Repositories;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CloudConfVarnaEdition4._0_RestAPI.Controllers
{
    [EnableCors(origins: "http://cloudconfvarnamicroservices.azurewebsites.net", headers: "*", methods: "*")]
    public class MatchesController : ApiController
    {
        private static readonly MongoDbMatchRepository _repository = new MongoDbMatchRepository();

        // GET api/matches
        public IEnumerable<Match> Get()
        {
            // Add Dummy records to database
            _repository.AddDummyMatches();

            return _repository.GetAllEntities();
        }
    }
}
