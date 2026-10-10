namespace Temprature_ConverterApp
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.lblResultOut = new System.Windows.Forms.Label();
            this.groupUnits = new System.Windows.Forms.GroupBox();
            this.F2CBtn = new System.Windows.Forms.RadioButton();
            this.C2FBtn = new System.Windows.Forms.RadioButton();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(204, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Converter App";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(45, 147);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(134, 22);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Enter Value:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(502, 144);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(81, 22);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(185, 143);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(266, 37);
            this.txtValue.TabIndex = 0;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertBtn.Location = new System.Drawing.Point(49, 508);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(176, 53);
            this.ConvertBtn.TabIndex = 1;
            this.ConvertBtn.Text = "&Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // lblResultOut
            // 
            this.lblResultOut.BackColor = System.Drawing.Color.White;
            this.lblResultOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultOut.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultOut.ForeColor = System.Drawing.Color.Black;
            this.lblResultOut.Location = new System.Drawing.Point(589, 139);
            this.lblResultOut.Name = "lblResultOut";
            this.lblResultOut.Size = new System.Drawing.Size(298, 41);
            this.lblResultOut.TabIndex = 5;
            this.lblResultOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupUnits
            // 
            this.groupUnits.Controls.Add(this.F2CBtn);
            this.groupUnits.Controls.Add(this.C2FBtn);
            this.groupUnits.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUnits.ForeColor = System.Drawing.Color.White;
            this.groupUnits.Location = new System.Drawing.Point(49, 252);
            this.groupUnits.Name = "groupUnits";
            this.groupUnits.Size = new System.Drawing.Size(838, 211);
            this.groupUnits.TabIndex = 6;
            this.groupUnits.TabStop = false;
            this.groupUnits.Text = "Select the units";
            // 
            // F2CBtn
            // 
            this.F2CBtn.AutoSize = true;
            this.F2CBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F2CBtn.ForeColor = System.Drawing.Color.White;
            this.F2CBtn.Location = new System.Drawing.Point(44, 127);
            this.F2CBtn.Name = "F2CBtn";
            this.F2CBtn.Size = new System.Drawing.Size(249, 26);
            this.F2CBtn.TabIndex = 1;
            this.F2CBtn.TabStop = true;
            this.F2CBtn.Text = "Fahrenheit to Celcius";
            this.F2CBtn.UseVisualStyleBackColor = true;
            // 
            // C2FBtn
            // 
            this.C2FBtn.AutoSize = true;
            this.C2FBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C2FBtn.ForeColor = System.Drawing.Color.White;
            this.C2FBtn.Location = new System.Drawing.Point(44, 71);
            this.C2FBtn.Name = "C2FBtn";
            this.C2FBtn.Size = new System.Drawing.Size(249, 26);
            this.C2FBtn.TabIndex = 0;
            this.C2FBtn.TabStop = true;
            this.C2FBtn.Text = "Celcius to Fehrenheit";
            this.C2FBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(370, 508);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(176, 53);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "&Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(711, 508);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(176, 53);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "&Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(926, 597);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.groupUnits);
            this.Controls.Add(this.lblResultOut);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupUnits.ResumeLayout(false);
            this.groupUnits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Label lblResultOut;
        private System.Windows.Forms.GroupBox groupUnits;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.RadioButton F2CBtn;
        private System.Windows.Forms.RadioButton C2FBtn;
    }
}

