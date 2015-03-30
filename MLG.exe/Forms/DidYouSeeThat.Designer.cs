namespace MLG.exe
{
    partial class DidYouSeeThat
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
            this.components = new System.ComponentModel.Container();
            this.butwait = new System.Windows.Forms.Label();
            this.seethat = new System.Windows.Forms.Label();
            this.seethatagain = new System.Windows.Forms.Label();
            this.textTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // butwait
            // 
            this.butwait.AutoSize = true;
            this.butwait.BackColor = System.Drawing.Color.Black;
            this.butwait.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butwait.ForeColor = System.Drawing.Color.White;
            this.butwait.Location = new System.Drawing.Point(482, 235);
            this.butwait.Name = "butwait";
            this.butwait.Size = new System.Drawing.Size(234, 55);
            this.butwait.TabIndex = 0;
            this.butwait.Text = "But wait...";
            this.butwait.Visible = false;
            // 
            // seethat
            // 
            this.seethat.AutoSize = true;
            this.seethat.BackColor = System.Drawing.Color.Black;
            this.seethat.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seethat.ForeColor = System.Drawing.Color.White;
            this.seethat.Location = new System.Drawing.Point(460, 128);
            this.seethat.Name = "seethat";
            this.seethat.Size = new System.Drawing.Size(376, 55);
            this.seethat.TabIndex = 1;
            this.seethat.Text = "Did you see that?";
            this.seethat.Visible = false;
            // 
            // seethatagain
            // 
            this.seethatagain.AutoSize = true;
            this.seethatagain.BackColor = System.Drawing.Color.Black;
            this.seethatagain.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seethatagain.ForeColor = System.Drawing.Color.White;
            this.seethatagain.Location = new System.Drawing.Point(266, 323);
            this.seethatagain.Name = "seethatagain";
            this.seethatagain.Size = new System.Drawing.Size(810, 73);
            this.seethatagain.TabIndex = 2;
            this.seethatagain.Text = "Lets see that again.................";
            this.seethatagain.Visible = false;
            // 
            // textTimer
            // 
            this.textTimer.Interval = 2000;
            this.textTimer.Tick += new System.EventHandler(this.textTimer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DidYouSeeThat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1306, 628);
            this.Controls.Add(this.seethatagain);
            this.Controls.Add(this.seethat);
            this.Controls.Add(this.butwait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DidYouSeeThat";
            this.Text = "DidYouSeeThat";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.DidYouSeeThat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label butwait;
        private System.Windows.Forms.Label seethat;
        private System.Windows.Forms.Label seethatagain;
        private System.Windows.Forms.Timer textTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}