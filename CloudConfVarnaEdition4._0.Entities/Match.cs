using CloudConfVarnaEdition4._0.Entities.interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConfVarnaEdition4._0.Entities
{
    public class Match : BaseEntity, IMatch
    {
        [BsonId]
        public BsonObjectId MatchID { get; set; }

        [Required]
        [BsonRepresentation(BsonType.String)]
        public string HomeTeam { get; set; }

        [Required]
        [BsonRepresentation(BsonType.String)]
        public string AwayTeam { get; set; }

        [Required]
        [BsonRepresentation(BsonType.Int32)]
        public int HomeTeamResult { get; set; }

        [Required]
        [BsonRepresentation(BsonType.Int32)]
        public int AwayTeamResult { get; set; }
    }
}
