using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaApp
{
    public partial class MainForm : Form
    {
        // attributes that can be changed w/ SetupForm
        public int NumQuestions { get; set; }
        public KeyValuePair<string, int> Category { get; set; }
        public string Difficulty { get; set; }

        private int Score;

        private OpenTriviaAPI API;
        private List<Question> Questions;
        private int QuestionCounter;
        private List<RadioButton> RadioButtons = new List<RadioButton>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set settings to defaults
            NumQuestions = 10;
            Category = new KeyValuePair<string, int>("All Categories", -1);
            Difficulty = "Medium";

            RadioButtons.Add(rdoAnswer1);
            RadioButtons.Add(rdoAnswer2);
            RadioButtons.Add(rdoAnswer3);
            RadioButtons.Add(rdoAnswer4);

            API = new OpenTriviaAPI();
            StartGame();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetupForm setup = new SetupForm();
            setup.Tag = this;
            setup.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            // find the button that's checked
            RadioButton checkedButton = null;
            foreach (RadioButton rb in RadioButtons)
            {
                if (rb.Checked)
                {
                    checkedButton = rb;
                    break;
                }
            }

            // if there's a selection, check the answer and move on
            if (checkedButton != null)
            {
                string answer = checkedButton.Text;
                CheckAnswer(answer);
            }
            else
            {
                MessageBox.Show("Please select an answer.", "No selection");
            }
        }

        private void StartGame()
        {
            lblScore.Text = "Score: 0";

            // enable the elements GameOver() disables
            foreach(RadioButton rb in RadioButtons)
            {
                rb.Enabled = true;
            }
            btnCheckAnswer.Enabled = true;

            // set labels to the settings for this game
            lblCategory.Text = Category.Key;
            lblDifficulty.Text = Difficulty;

            // get the questions from the API
            Questions = API.GetQuestions(NumQuestions, Category.Value, Difficulty);
            
            // set counters to 0
            QuestionCounter = 0;
            Score = 0;

            NextQuestion();
        }

        private void NextQuestion()
        {
            // uncheck all radio buttons
            foreach (RadioButton rb in RadioButtons)
            {
                rb.Checked = false;
            }

            Question question = Questions[QuestionCounter];
            lblQuestion.Text = question.QuestionText;

            List<string> answers = question.AllAnswers;
            
            // set the texts of the radio buttons to the answers from the question object
            for (int i = 0; i < RadioButtons.Count; i++)
            {
                RadioButtons[i].Text = answers[i];
            }
        }

        private void CheckAnswer(string answer)
        {
            Question question = Questions[QuestionCounter];

            if (question.IsCorrect(answer))
            {
                Score++;
                lblScore.Text = $"Score: {Score}";
                MessageBox.Show($"That's right!\n\nScore: {Score}", "Correct!");
            }
            else
            {
                string correctAnswer = question.CorrectAnswer;
                MessageBox.Show($"Sorry, that's wrong. The correct answer was \"{correctAnswer}\"\n\nScore: {Score}", "Incorrect");
            }

            QuestionCounter++;
            if (QuestionCounter < Questions.Count)
            {
                NextQuestion();
            }
            else
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            // disable elements
            foreach(RadioButton rb in RadioButtons)
            {
                rb.Enabled = false;
            }
            btnCheckAnswer.Enabled = false;

            MessageBox.Show("Game Details:\n\n" +
                $"Category: {lblCategory.Text}\nDifficulty: {lblDifficulty.Text}\n\n" +
                $"Final Result:\n\nYou got {Score} right out of {Questions.Count} questions!", "Game Over!");
        }
    }
}
