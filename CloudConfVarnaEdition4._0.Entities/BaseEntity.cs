using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudConfVarnaEdition4._0.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
