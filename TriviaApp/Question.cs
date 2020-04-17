using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// This is almost entirely copied from the QuizApp from Lab 9

namespace TriviaApp
{
    class Question
    {
        public Question(string questionText, string correctAnswer, List<string> incorrectAnswers){
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
            IncorrectAnswers = incorrectAnswers;
        }

        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; set; }

        public List<string> AllAnswers
        {
            get
            {
                List<string> allAnswers = new List<string>();

                // add correct and wrong answers to list of all answers
                allAnswers.Add(CorrectAnswer);
                allAnswers.AddRange(IncorrectAnswers);

                Random random = new Random();
                List<string> shuffledAnswers = new List<string>();

                while (allAnswers.Count > 0)
                {
                    // remove an answer at a random index in allAnswers
                    int index = random.Next(allAnswers.Count);
                    string answer = allAnswers[index];
                    allAnswers.RemoveAt(index);

                    // insert that answer at a random index in shuffledAnswers
                    int insertIndex = random.Next(shuffledAnswers.Count);
                    shuffledAnswers.Insert(insertIndex, answer);
                }

                return shuffledAnswers;
            }
        }

        public bool IsCorrect(string chosenAnswer)
        {
            return chosenAnswer.Equals(CorrectAnswer);
        }
    }
}
