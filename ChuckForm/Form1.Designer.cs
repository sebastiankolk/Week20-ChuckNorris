namespace ChuckForm
{
    partial class Form1
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
            this.GetJokesBtn = new System.Windows.Forms.Button();
            this.jokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GetJokesBtn
            // 
            this.GetJokesBtn.Location = new System.Drawing.Point(529, 27);
            this.GetJokesBtn.Name = "GetJokesBtn";
            this.GetJokesBtn.Size = new System.Drawing.Size(70, 23);
            this.GetJokesBtn.TabIndex = 0;
            this.GetJokesBtn.Text = "Get Joke";
            this.GetJokesBtn.UseVisualStyleBackColor = true;
            this.GetJokesBtn.Click += new System.EventHandler(this.GetJokesBtn_Click);
            // 
            // jokeBox
            // 
            this.jokeBox.Location = new System.Drawing.Point(529, 110);
            this.jokeBox.Name = "jokeBox";
            this.jokeBox.Size = new System.Drawing.Size(270, 235);
            this.jokeBox.TabIndex = 1;
            this.jokeBox.Text = "Get a joke, i dare you!";
            this.jokeBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChuckForm.Properties.Resources.chucknorris_jpeg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jokeBox);
            this.Controls.Add(this.GetJokesBtn);
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetJokesBtn;
        private System.Windows.Forms.RichTextBox jokeBox;
    }
}

