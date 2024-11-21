using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreC.Models.DTO.Request
{
    public class Add
    {
        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }
    }
}
