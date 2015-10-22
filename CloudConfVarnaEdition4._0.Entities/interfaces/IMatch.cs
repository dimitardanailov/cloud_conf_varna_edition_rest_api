using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConfVarnaEdition4._0.Entities.interfaces
{
    public interface IMatch
    {
        BsonObjectId MatchID { get; set; }

        string HomeTeam { get; set; }

        string AwayTeam { get; set; }

        int HomeTeamResult { get; set; }

        int AwayTeamResult { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }
    }
}
