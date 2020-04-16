using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaApp
{
    class OpenTriviaAPI
    {
        private readonly string apiURL = "https://opentdb.com/api.php?type=multiple";
        private readonly string specifyAmount = "&amount=";
        private readonly string specifyCategory = "&category=";
        private readonly string specifyDifficulty = "&difficulty=";

        public List<Question> GetQuestions(int amount, string category, string difficulty)
        {
            throw new NotImplementedException();
        }
    }
}
