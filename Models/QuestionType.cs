using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmigration.Models
{
    public class QuestionType
    {

        public int QuestionTypeId { get; set; }

        public string Type { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }


        public virtual List<Question> Question { get; set; }



    }
}
