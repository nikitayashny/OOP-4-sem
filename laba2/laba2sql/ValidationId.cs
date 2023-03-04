using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace laba2sql
{
    public class ValidationId
    {
        [RegularExpression(@"^[1-9]\d*$")]
        public string Id { get; set; }

        public ValidationId(string id) => Id = id;
    }
}
