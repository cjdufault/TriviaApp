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
    public partial class SetupForm : Form
    {
        private Dictionary<string, int> Categories = new Dictionary<string, int>();
        private MainForm MainWindow;

        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            MainWindow = (MainForm) Tag;

            // add category names and corresponding codes to Categories dict
            Categories.Add("All Categories", -1);
            Categories.Add("General Knowledge", 9); // starts @ 9 for some reason???
            Categories.Add("Books", 10);
            Categories.Add("Film", 11);
            Categories.Add("Music", 12);
            Categories.Add("Musicals & Theatre", 13);
            Categories.Add("Television", 14);
            Categories.Add("Video Games", 15);
            Categories.Add("Board Games", 16);
            Categories.Add("Science & Nature", 17);
            Categories.Add("Computers", 18);
            Categories.Add("Mathematics", 19);
            Categories.Add("Mythology", 20);
            Categories.Add("Sports", 21);
            Categories.Add("Geography", 22);
            Categories.Add("History", 23);
            Categories.Add("Politics", 24);
            Categories.Add("Art", 25);
            Categories.Add("Celebrities", 26);
            Categories.Add("Animals", 27);
            Categories.Add("Vehicles", 28);
            Categories.Add("Comics", 29);
            Categories.Add("Gadgets", 30);
            Categories.Add("Japanese Anime & Manga", 31);
            Categories.Add("Cartoons & Animations", 32);

            cboCategory.Items.AddRange(Categories.Keys.ToArray()); // add all categories to category combobox

            // add difficulty level options to combobox
            cboDifficulty.Items.Add("Easy");
            cboDifficulty.Items.Add("Medium");
            cboDifficulty.Items.Add("Hard");

            // set everything to the values that the main form has
            numQuestions.Value = MainWindow.NumQuestions;
            cboCategory.SelectedItem = MainWindow.Category.Key;
            cboDifficulty.SelectedItem = MainWindow.Difficulty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string category = cboCategory.SelectedItem.ToString();

            // save the selections made to their corresponding attributes in the main form
            MainWindow.NumQuestions = (int) numQuestions.Value;
            MainWindow.Category = new KeyValuePair<string, int>(category, Categories[category]);
            MainWindow.Difficulty = cboDifficulty.SelectedItem.ToString();
            Dispose();
        }
    }
}
