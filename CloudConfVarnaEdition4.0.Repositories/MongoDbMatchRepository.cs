using CloudConfVarnaEdition4._0.Entities;
using CloudConfVarnaEdition4._0.Repositories.interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConfVarnaEdition4._0.Repositories
{
    public class MongoDbMatchRepository : MongoDbRepository<Match>, IMatchRepository
    {
        public const string collectionName = "Matches";


        public MongoDbMatchRepository() : base(collectionName)
        {

        }

        public IEnumerable<Match> GetAllMatches()
        {
            return this.GetAllEntities();
        }

        public Match GetMatch(string MatchID)
        {
            return this.GetEntity(MatchID);
        }

        public Match AddMatch(Match item)
        {
            _entities.Insert(item);

            return item;
        }

        public bool RemoveMatch(string MatchID)
        {
            return this.RemoveEntity(MatchID);
        }

        public bool UpdateMatch(string MatchID, Match item)
        {
            IMongoQuery query = Query.EQ("_id", MatchID);
            item.UpdatedAt = DateTime.UtcNow;
            IMongoUpdate update = Update
                .Set("HomeTeam", item.HomeTeam)
                .Set("AwayTeam", item.AwayTeam)
                .Set("HomeTeamResult", item.HomeTeamResult)
                .Set("AwayTeamResult", item.AwayTeamResult);
            WriteConcernResult result = _entities.Update(query, update);

            return result.UpdatedExisting;
        }

        /// <summary>
        /// Add couple of dummy matches.
        /// We use latest Champion Results (Results from 21 October 2015)
        /// </summary>
        public void AddDummyMatches()
        {
            // Reset database
            _entities.RemoveAll();
            List<Match> listMatches = new List<Match>();

            listMatches.Add(new Match("Malmoe FF", "Shakhtar Donetsk", 1, 0));
            listMatches.Add(new Match("Paris Saint Germain", "Real Madrid", 0, 0));
            listMatches.Add(new Match("CSKA Moscow", "Manchester United", 1, 1));
            listMatches.Add(new Match("Wolfsburg", "PSV Eindhoven", 2, 0));
            listMatches.Add(new Match("Atletico Madrid", "Atletico Madrid", 4, 0));
            listMatches.Add(new Match("Galatasaray", "Benfica", 2, 1));
            listMatches.Add(new Match("Juventus", "Borussia Moenchengladbach", 0, 0));
            listMatches.Add(new Match("Manchester City", "Sevilla", 2, 1));

            foreach (var match in listMatches)
            {
                AddMatch(match);
            }
        }
    }
}
