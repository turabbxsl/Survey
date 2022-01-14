using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmigration.Models
{
    public class Survey
    {

        public int SurveyId { get; set; }

        public string SurveyName { get; set; }


        public virtual List<QuestionType> QuestionType { get; set; }




    }
}
