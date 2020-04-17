using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Buffers;

namespace TriviaApp
{
    class OpenTriviaAPI
    {
        private readonly string BaseURL = "https://opentdb.com/api.php?type=multiple";

        public List<Question> GetQuestions(int amount, int categoryCode, string difficulty)
        {
            WebClient client = new WebClient();

            string requestURL = $"{BaseURL}&amount={amount}&difficulty={difficulty.ToLower()}";

            if (categoryCode != -1)
            {
                requestURL += $"&category={categoryCode}";
            }

            using (client)
            {
                try
                {
                    // get json from api
                    string response = client.DownloadString(requestURL);

                    // convert to a byte array and make a reader to read in bytes
                    byte[] data = Encoding.UTF8.GetBytes(response);
                    Utf8JsonReader reader = new Utf8JsonReader(data);

                    List<Question> questions = new List<Question>();

                    // make JsonDocument to parse json
                    using (JsonDocument document = JsonDocument.Parse(response))
                    {
                        JsonElement results = document.RootElement.GetProperty("results");

                        // iterate over each question, getting question, correct answer, and wrong answers
                        foreach (JsonElement result in results.EnumerateArray())
                        {
                            string questionText = result.GetProperty("question").GetString();
                            string correctAnswer = result.GetProperty("correct_answer").GetString();

                            List<string> incorrectAnswers = new List<string>();
                            JsonElement incorrectAnswersJsonElement = result.GetProperty("incorrect_answers");
                            foreach (JsonElement incorrectAnswer in incorrectAnswersJsonElement.EnumerateArray())
                            {
                                incorrectAnswers.Add(incorrectAnswer.ToString());
                            }

                            // make a Question object from the result
                            questions.Add(new Question(questionText, correctAnswer, incorrectAnswers));
                        }
                    }

                    return questions;
                }
                catch (WebException e)
                {
                    Console.WriteLine("Error fetching data from API: " + e.Message);
                    Console.WriteLine(e.StackTrace);
                }
                catch (JsonException e)
                {
                    Console.WriteLine("Error parsing JSON data: " + e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }

            return null;
        }
    }
}
