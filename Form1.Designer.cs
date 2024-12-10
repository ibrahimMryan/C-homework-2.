namespace guss_the_number
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_guess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_newGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "I have a number between 1 and 1000--can you guess my number? Please enter your gu" +
    "ess";
            // 
            // textBox_guess
            // 
            this.textBox_guess.Location = new System.Drawing.Point(133, 84);
            this.textBox_guess.Name = "textBox_guess";
            this.textBox_guess.Size = new System.Drawing.Size(227, 22);
            this.textBox_guess.TabIndex = 1;
            this.textBox_guess.TextChanged += new System.EventHandler(this.textBox_guess_TextChanged);
            this.textBox_guess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_guess_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "guess result appears here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_newGame
            // 
            this.button_newGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_newGame.Location = new System.Drawing.Point(133, 162);
            this.button_newGame.Name = "button_newGame";
            this.button_newGame.Size = new System.Drawing.Size(213, 55);
            this.button_newGame.TabIndex = 3;
            this.button_newGame.Text = "New game";
            this.button_newGame.UseVisualStyleBackColor = false;
            this.button_newGame.Click += new System.EventHandler(this.button_newGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 259);
            this.Controls.Add(this.button_newGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_guess);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_guess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_newGame;
    }
}

