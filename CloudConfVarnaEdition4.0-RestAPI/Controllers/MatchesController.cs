using CloudConfVarnaEdition4._0.Entities;
using CloudConfVarnaEdition4._0.Repositories;
using CloudConfVarnaEdition4._0.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace CloudConfVarnaEdition4._0_RestAPI.Controllers
{
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
