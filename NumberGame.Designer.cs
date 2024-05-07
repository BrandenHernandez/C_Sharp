namespace NumberGame
{
    partial class NumberPanel
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
            this.txtbGuess = new System.Windows.Forms.TextBox();
            this.Indicator = new System.Windows.Forms.Label();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "I have a number between 1 and 1000 -- can you guess my number?\r\n\r\nPlease enter yo" +
    "ur first guess.";
            // 
            // txtbGuess
            // 
            this.txtbGuess.Enabled = false;
            this.txtbGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.txtbGuess.Location = new System.Drawing.Point(16, 66);
            this.txtbGuess.Name = "txtbGuess";
            this.txtbGuess.Size = new System.Drawing.Size(162, 20);
            this.txtbGuess.TabIndex = 1;
            this.txtbGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbGuess.TextChanged += new System.EventHandler(this.TxtbGuess_TextChanged);
            // 
            // Indicator
            // 
            this.Indicator.AutoSize = true;
            this.Indicator.Location = new System.Drawing.Point(16, 93);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(0, 13);
            this.Indicator.TabIndex = 2;
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicator.Location = new System.Drawing.Point(16, 93);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(80, 20);
            this.lblIndicator.TabIndex = 3;
            this.lblIndicator.Text = "Indicator";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(187, 93);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(234, 38);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(51, 13);
            this.lblCounter.TabIndex = 5;
            this.lblCounter.Text = "Game #1";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(187, 62);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(151, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enter";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // NumberPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 132);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.txtbGuess);
            this.Controls.Add(this.label1);
            this.Name = "NumberPanel";
            this.Text = "Guess the Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbGuess;
        private System.Windows.Forms.Label Indicator;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnSend;
    }
}

