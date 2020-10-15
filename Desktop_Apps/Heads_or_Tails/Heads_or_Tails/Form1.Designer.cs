namespace Heads_or_Tails
{
    partial class frmCoinToss
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
            this.btnheads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.picTails = new System.Windows.Forms.PictureBox();
            this.picHeads = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
            this.SuspendLayout();
            // 
            // btnheads
            // 
            this.btnheads.Location = new System.Drawing.Point(12, 173);
            this.btnheads.Name = "btnheads";
            this.btnheads.Size = new System.Drawing.Size(153, 29);
            this.btnheads.TabIndex = 0;
            this.btnheads.Text = "Show Heads";
            this.btnheads.UseVisualStyleBackColor = true;
            this.btnheads.Click += new System.EventHandler(this.btnheads_Click_2);
            // 
            // btnTails
            // 
            this.btnTails.Location = new System.Drawing.Point(180, 173);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(153, 29);
            this.btnTails.TabIndex = 1;
            this.btnTails.Text = "Show Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.button2_Click);
            // 
            // picTails
            // 
            this.picTails.Image = global::Heads_or_Tails.Properties.Resources.Quarter_Tails;
            this.picTails.Location = new System.Drawing.Point(180, 12);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(153, 143);
            this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTails.TabIndex = 3;
            this.picTails.TabStop = false;
            // 
            // picHeads
            // 
            this.picHeads.Image = global::Heads_or_Tails.Properties.Resources.quarter_clipart_quarter_1213;
            this.picHeads.Location = new System.Drawing.Point(12, 12);
            this.picHeads.Name = "picHeads";
            this.picHeads.Size = new System.Drawing.Size(153, 143);
            this.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeads.TabIndex = 2;
            this.picHeads.TabStop = false;
            // 
            // frmCoinToss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 210);
            this.Controls.Add(this.picTails);
            this.Controls.Add(this.picHeads);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnheads);
            this.Name = "frmCoinToss";
            this.Text = "Coin Toss";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnheads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.PictureBox picHeads;
        private System.Windows.Forms.PictureBox picTails;
    }
}

