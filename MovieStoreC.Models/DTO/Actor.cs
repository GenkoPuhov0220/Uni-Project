using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.Models.DTO
{
    public class Actor
    {
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; }
    }
}
