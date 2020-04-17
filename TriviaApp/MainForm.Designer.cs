namespace TriviaApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoAnswer4 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdoAnswer1 = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(13, 13);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(177, 45);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Game Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(1057, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(165, 45);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(1044, 720);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(178, 45);
            this.btnCheckAnswer.TabIndex = 3;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(229, 72);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(775, 303);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoAnswer4);
            this.panel1.Controls.Add(this.rdoAnswer3);
            this.panel1.Controls.Add(this.rdoAnswer2);
            this.panel1.Controls.Add(this.rdoAnswer1);
            this.panel1.Location = new System.Drawing.Point(238, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 305);
            this.panel1.TabIndex = 5;
            // 
            // rdoAnswer4
            // 
            this.rdoAnswer4.AutoSize = true;
            this.rdoAnswer4.Location = new System.Drawing.Point(51, 236);
            this.rdoAnswer4.Name = "rdoAnswer4";
            this.rdoAnswer4.Size = new System.Drawing.Size(27, 26);
            this.rdoAnswer4.TabIndex = 3;
            this.rdoAnswer4.TabStop = true;
            this.rdoAnswer4.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer3
            // 
            this.rdoAnswer3.AutoSize = true;
            this.rdoAnswer3.Location = new System.Drawing.Point(51, 172);
            this.rdoAnswer3.Name = "rdoAnswer3";
            this.rdoAnswer3.Size = new System.Drawing.Size(27, 26);
            this.rdoAnswer3.TabIndex = 2;
            this.rdoAnswer3.TabStop = true;
            this.rdoAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer2
            // 
            this.rdoAnswer2.AutoSize = true;
            this.rdoAnswer2.Location = new System.Drawing.Point(51, 105);
            this.rdoAnswer2.Name = "rdoAnswer2";
            this.rdoAnswer2.Size = new System.Drawing.Size(27, 26);
            this.rdoAnswer2.TabIndex = 1;
            this.rdoAnswer2.TabStop = true;
            this.rdoAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdoAnswer1
            // 
            this.rdoAnswer1.AutoSize = true;
            this.rdoAnswer1.Location = new System.Drawing.Point(51, 39);
            this.rdoAnswer1.Name = "rdoAnswer1";
            this.rdoAnswer1.Size = new System.Drawing.Size(27, 26);
            this.rdoAnswer1.TabIndex = 0;
            this.rdoAnswer1.TabStop = true;
            this.rdoAnswer1.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 720);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(146, 25);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "All Categories";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(12, 749);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(176, 25);
            this.lblDifficulty.TabIndex = 7;
            this.lblDifficulty.Text = "Medium Difficulty";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(526, 721);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(136, 37);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score: 0";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCheckAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 796);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnSettings);
            this.Name = "MainForm";
            this.Text = "Trivia App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoAnswer4;
        private System.Windows.Forms.RadioButton rdoAnswer3;
        private System.Windows.Forms.RadioButton rdoAnswer2;
        private System.Windows.Forms.RadioButton rdoAnswer1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblScore;
    }
}

