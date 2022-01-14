using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmigration.Models
{
    public class Question
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public int QuestionTypeId { get; set; }
        public QuestionType QuestionType { get; set; }

        public virtual List<Answer> Answers{ get; set; }

        

    }
}
