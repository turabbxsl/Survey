using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmigration.Models
{
    public class Question2
    {

        public int Question2Id { get; set; }
        public string Name { get; set; }

        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
