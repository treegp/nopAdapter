namespace nopAdapterMain
{
    partial class DataManagement
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
            this.RunButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.CatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(137, 12);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(110, 32);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 50);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(469, 266);
            this.LogTextBox.TabIndex = 1;
            // 
            // CatchButton
            // 
            this.CatchButton.Location = new System.Drawing.Point(12, 12);
            this.CatchButton.Name = "CatchButton";
            this.CatchButton.Size = new System.Drawing.Size(110, 32);
            this.CatchButton.TabIndex = 0;
            this.CatchButton.Text = "Catch";
            this.CatchButton.UseVisualStyleBackColor = true;
            this.CatchButton.Click += new System.EventHandler(this.CatchButton_Click);
            // 
            // DataManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 328);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.CatchButton);
            this.Controls.Add(this.RunButton);
            this.Name = "DataManagement";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button CatchButton;
    }
}

