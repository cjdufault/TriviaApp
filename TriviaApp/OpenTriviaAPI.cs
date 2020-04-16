using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaApp
{
    class OpenTriviaAPI
    {
        private readonly string ApiURL = "https://opentdb.com/api.php?type=multiple";
        private readonly string SpecifyAmount = "&amount=";
        private readonly string SpecifyCategory = "&category=";
        private readonly string SpecifyDifficulty = "&difficulty=";

        public List<Question> GetQuestions(int amount, string category, string difficulty)
        {
            throw new NotImplementedException();
        }
    }
}
