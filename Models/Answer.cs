using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmigration.Models
{
    public class Answer
    {

        public int Id { get; set; }

        public string Name { get; set; }

        

        public int QuestionId { get; set; }
        public Question Question { get; set; }




    }
}
