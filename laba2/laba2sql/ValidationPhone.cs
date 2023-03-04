using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace laba2sql
{
    public class ValidationPhone
    {
        [RegularExpression(@"^\+[1-9]\d{2}-\d{2}-\d{7}$")]
        public string Phone { get; set; }

        public ValidationPhone(string phone) => Phone = phone;
    }
}
