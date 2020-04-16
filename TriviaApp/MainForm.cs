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

        public int NumQuestions { get; set; }
        public KeyValuePair<string, int> Category { get; set; }
        public string Difficulty { get; set; }

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
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetupForm setup = new SetupForm();
            setup.Tag = this;
            setup.Show();
        }

    }
}
