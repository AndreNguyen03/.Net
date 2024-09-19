namespace Baitap1
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
            this.Enter = new System.Windows.Forms.Button();
            this.Statistic = new System.Windows.Forms.Button();
            this.Absentee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(104, 45);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(148, 39);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Enter number of each species";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Statistic
            // 
            this.Statistic.Location = new System.Drawing.Point(130, 171);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(97, 26);
            this.Statistic.TabIndex = 1;
            this.Statistic.Text = "Statistic";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // Absentee
            // 
            this.Absentee.Location = new System.Drawing.Point(130, 112);
            this.Absentee.Name = "Absentee";
            this.Absentee.Size = new System.Drawing.Size(97, 26);
            this.Absentee.TabIndex = 2;
            this.Absentee.Text = "Absentee";
            this.Absentee.UseVisualStyleBackColor = true;
            this.Absentee.Click += new System.EventHandler(this.Absentee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 272);
            this.Controls.Add(this.Absentee);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.Enter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Statistic;
        private System.Windows.Forms.Button Absentee;
    }
}

