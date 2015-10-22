using CloudConfVarnaEdition4._0.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConfVarnaEdition4._0.Repositories.interfaces
{
    public interface IMatchRepository
    {
        IEnumerable<Match> GetAllMatches();

        Match GetMatch(string MatchID);

        Match AddMatch(Match item);

        bool RemoveMatch(string MatchID);

        bool UpdateMatch(string MatchID, Match item);
    }
}
