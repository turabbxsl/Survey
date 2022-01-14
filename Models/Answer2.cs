using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmigration.Models
{
    public class Answer2
    {
        public int Answer2Id { get; set; }

        public string Name { get; set; }


        public int Question2Id { get; set; }
        public Question2 Question2 { get; set; }
    }
}
