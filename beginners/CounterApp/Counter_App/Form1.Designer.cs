namespace Counter_App
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
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountInformation = new System.Windows.Forms.Label();
            this.decreaseBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.increaseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(349, 81);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(150, 163);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "0";
            // 
            // lblCountInformation
            // 
            this.lblCountInformation.AutoSize = true;
            this.lblCountInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountInformation.ForeColor = System.Drawing.Color.White;
            this.lblCountInformation.Location = new System.Drawing.Point(314, 355);
            this.lblCountInformation.Name = "lblCountInformation";
            this.lblCountInformation.Size = new System.Drawing.Size(255, 46);
            this.lblCountInformation.TabIndex = 1;
            this.lblCountInformation.Text = "Counter App";
            this.lblCountInformation.Click += new System.EventHandler(this.label2_Click);
            // 
            // decreaseBtn
            // 
            this.decreaseBtn.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseBtn.Location = new System.Drawing.Point(240, 450);
            this.decreaseBtn.Name = "decreaseBtn";
            this.decreaseBtn.Size = new System.Drawing.Size(75, 56);
            this.decreaseBtn.TabIndex = 2;
            this.decreaseBtn.Text = "-";
            this.decreaseBtn.UseVisualStyleBackColor = true;
            this.decreaseBtn.Click += new System.EventHandler(this.decreaseBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(337, 448);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(174, 58);
            this.ResetBtn.TabIndex = 3;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click_1);
            // 
            // increaseBtn
            // 
            this.increaseBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseBtn.Location = new System.Drawing.Point(534, 448);
            this.increaseBtn.Name = "increaseBtn";
            this.increaseBtn.Size = new System.Drawing.Size(93, 58);
            this.increaseBtn.TabIndex = 4;
            this.increaseBtn.Text = "+";
            this.increaseBtn.UseVisualStyleBackColor = true;
            this.increaseBtn.Click += new System.EventHandler(this.increaseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(867, 575);
            this.Controls.Add(this.increaseBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.decreaseBtn);
            this.Controls.Add(this.lblCountInformation);
            this.Controls.Add(this.lblCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountInformation;
        private System.Windows.Forms.Button decreaseBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button increaseBtn;
    }
}

