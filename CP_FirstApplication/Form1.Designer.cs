namespace CP_FirstApplication
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
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.textBoxCalculateValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(85, 42);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeft.TabIndex = 1;
            this.textBoxLeft.TextChanged += new System.EventHandler(this.TextBoxLeft_TextChanged);
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(225, 42);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(100, 20);
            this.textBoxRight.TabIndex = 2;
            this.textBoxRight.TextChanged += new System.EventHandler(this.TextBoxRight_TextChanged);
            // 
            // textBoxCalculateValue
            // 
            this.textBoxCalculateValue.Location = new System.Drawing.Point(251, 121);
            this.textBoxCalculateValue.Name = "textBoxCalculateValue";
            this.textBoxCalculateValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalculateValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 168);
            this.Controls.Add(this.textBoxCalculateValue);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.textBoxLeft);
            this.Name = "Form1";
            this.Text = "Calc V0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.TextBox textBoxCalculateValue;
    }
}

