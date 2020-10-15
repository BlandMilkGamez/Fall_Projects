namespace JokeandPunch
{
    partial class frmJoke
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
            this.btwSetup = new System.Windows.Forms.Button();
            this.btnPunchLine = new System.Windows.Forms.Button();
            this.lblJoke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btwSetup
            // 
            this.btwSetup.Location = new System.Drawing.Point(12, 69);
            this.btwSetup.Name = "btwSetup";
            this.btwSetup.Size = new System.Drawing.Size(129, 23);
            this.btwSetup.TabIndex = 0;
            this.btwSetup.Text = "Setup   ";
            this.btwSetup.UseVisualStyleBackColor = true;
            this.btwSetup.Click += new System.EventHandler(this.btwSetup_Click);
            // 
            // btnPunchLine
            // 
            this.btnPunchLine.Location = new System.Drawing.Point(149, 69);
            this.btnPunchLine.Name = "btnPunchLine";
            this.btnPunchLine.Size = new System.Drawing.Size(129, 23);
            this.btnPunchLine.TabIndex = 1;
            this.btnPunchLine.Text = "Punch Line";
            this.btnPunchLine.UseVisualStyleBackColor = true;
            this.btnPunchLine.Click += new System.EventHandler(this.btnPunchLine_Click);
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(104, 32);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(0, 13);
            this.lblJoke.TabIndex = 2;
            this.lblJoke.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmJoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 99);
            this.Controls.Add(this.lblJoke);
            this.Controls.Add(this.btnPunchLine);
            this.Controls.Add(this.btwSetup);
            this.Name = "frmJoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btwSetup;
        private System.Windows.Forms.Button btnPunchLine;
        private System.Windows.Forms.Label lblJoke;
    }
}

