namespace Baitap1.Presenter_Layer
{
    partial class EnterDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCow = new System.Windows.Forms.TextBox();
            this.tbSheep = new System.Windows.Forms.TextBox();
            this.tbGoat = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(136, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(136, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sheep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(136, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Goat";
            // 
            // tbCow
            // 
            this.tbCow.Location = new System.Drawing.Point(210, 83);
            this.tbCow.Name = "tbCow";
            this.tbCow.Size = new System.Drawing.Size(100, 20);
            this.tbCow.TabIndex = 3;
            // 
            // tbSheep
            // 
            this.tbSheep.Location = new System.Drawing.Point(210, 129);
            this.tbSheep.Name = "tbSheep";
            this.tbSheep.Size = new System.Drawing.Size(100, 20);
            this.tbSheep.TabIndex = 4;
            // 
            // tbGoat
            // 
            this.tbGoat.Location = new System.Drawing.Point(210, 173);
            this.tbGoat.Name = "tbGoat";
            this.tbGoat.Size = new System.Drawing.Size(100, 20);
            this.tbGoat.TabIndex = 5;
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ok.Location = new System.Drawing.Point(184, 252);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // EnterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 323);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.tbGoat);
            this.Controls.Add(this.tbSheep);
            this.Controls.Add(this.tbCow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnterDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCow;
        private System.Windows.Forms.TextBox tbSheep;
        private System.Windows.Forms.TextBox tbGoat;
        private System.Windows.Forms.Button Ok;
    }
}